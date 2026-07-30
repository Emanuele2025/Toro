using System;
using System;
using System.Collections.Generic;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
namespace Toro
{


    public class UsbDetection
    {
        private ManagementEventWatcher insertWatcher;
        private ManagementEventWatcher removeWatcher;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        static extern uint QueryDosDevice(string lpDeviceName, StringBuilder lpTargetPath, uint ucchMax);

        public string UnitaDeviceName { get; set; }


        public void StartListening()
        {
            // Query per dispositivi USB inseriti
            WqlEventQuery insertQuery = new WqlEventQuery("__InstanceCreationEvent",
                new TimeSpan(0, 0, 1),
                "TargetInstance ISA 'Win32_USBHub'");

            insertWatcher = new ManagementEventWatcher(insertQuery);
            insertWatcher.EventArrived += new EventArrivedEventHandler(DeviceInsertedEvent);
            insertWatcher.Start();

            // Query per dispositivi USB rimossi
            WqlEventQuery removeQuery = new WqlEventQuery("__InstanceDeletionEvent",
                new TimeSpan(0, 0, 1),
                "TargetInstance ISA 'Win32_USBHub'");

            removeWatcher = new ManagementEventWatcher(removeQuery);
            removeWatcher.EventArrived += new EventArrivedEventHandler(DeviceRemovedEvent);
            removeWatcher.Start();
        }

        public void StopListening()
        {
            if (insertWatcher != null)
            {
                insertWatcher.Stop();
                insertWatcher.Dispose();
            }
            if (removeWatcher != null)
            {
                removeWatcher.Stop();
                removeWatcher.Dispose();
            }
        }

        private void DeviceInsertedEvent(object sender, EventArrivedEventArgs e)
        {
            var instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
            string deviceID = (string)instance["DeviceID"];
            UnitaDeviceName = deviceID;
            Console.WriteLine("USB inserito: " + deviceID);
            // Puoi filtrare ulteriormente per identificare le chiavette USB
        }

        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
            var instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
            string deviceID = (string)instance["DeviceID"];
            UnitaDeviceName = deviceID;
            Console.WriteLine("USB rimosso: " + deviceID);
            // Puoi filtrare ulteriormente
        }

        public bool GetLettera(string lettera)
        {

            string deviceID = UnitaDeviceName;// "USBSTOR\\DISK&VEN_SANDISK&PROD_U3_GENERATION_II&REV_1.00\\AB0C1234";
            bool letteraTrovata = false;
            // Lista tutte le lettere di unità



            StringBuilder targetPath = new StringBuilder(1024);
            uint result = QueryDosDevice(lettera.Substring(0, 2), targetPath, (uint)targetPath.Capacity);
            if (result != 0)
            {
                string devicePath = targetPath.ToString();
                letteraTrovata = devicePath.Contains(deviceID);

            }
            return letteraTrovata;





        }

    }
}
