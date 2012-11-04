using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Puffy.Voip
{
    public class SimContactProvider
    {
        private const Int64 S_OK = 0x00000000;
        public const int SIM_CAPSTYPE_ALL = 0x3F; // All device cabability types
        public const int SIM_PBSTORAGE_SIM = 0x10; // General SIM Storage
        public const int SIM_SMSSTORAGE_SIM = 0x2; // SIM storage location

        [StructLayout(LayoutKind.Sequential)]
        public struct SIMPHONEBOOKENTRY
        {
            public uint cbSize; // Size of the structure in bytes
            public uint dwParams; // Indicates valid parameter values
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string lpszAddress; // The actual phone number
            public uint dwAddressType; // A SIM_ADDRTYPE_*constant
            public uint dwNumPlan; // A SIM_NUMPLAN_*constant
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string lpszText; // Text assocaited with the entry
        }

        [DllImport("cellcore.dll")]
        public static extern int SimInitialize(uint dwFlags,
        int lpfnCallBack, uint dwParam, ref int lphSim);
        [DllImport("cellcore.dll")]
        public static extern int SimGetPhonebookStatus(int hSim,
        uint dwLocation, ref uint lpdwUsed, ref uint lpdwTotal);
        [DllImport("cellcore.dll")]
        public static extern int SimReadPhonebookEntry(int hSim, uint dwLocation, uint dwIndex, ref SIMPHONEBOOKENTRY entry);
        [DllImport("cellcore.dll", SetLastError = true)]
        public static extern int SimDeinitialize(int hSim);

        public List<ContactNumber> GetSimContacts()
        {
            int hSim = 0;
            var list = new List<ContactNumber>();
            
            try
            {
                int result = SimInitialize(0, 0, 0, ref hSim);
                if (result != 0)
                    throw new Exception("SIM Contacts");

                uint uiUsed = 0;
                uint uiTotal = 0;
                result = SimGetPhonebookStatus(hSim, SIM_PBSTORAGE_SIM, ref uiUsed, ref uiTotal);
                
                for (int i = 1; i <= uiUsed; i++)
                {
                    SIMPHONEBOOKENTRY entry = new SIMPHONEBOOKENTRY();
                    entry.cbSize = (uint)Marshal.SizeOf(typeof(SIMPHONEBOOKENTRY));
                    result = SimReadPhonebookEntry(hSim, SIM_PBSTORAGE_SIM, (uint)i, ref entry);

                    list.Add(new ContactNumber()
                             {
                                 Name = entry.lpszText,
                                 Number = entry.lpszAddress
                             });
                }
                
                return list;
            }
            finally
            {
                SimDeinitialize(hSim);
            }
        }
    }
}