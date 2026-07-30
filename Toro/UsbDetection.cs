using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Management;
namespace Toro
{
    

    public class UsbDetection
    {
        private ManagementEventWatcher insertWatcher;
        private ManagementEventWatcher removeWatcher;

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
            Console.WriteLine("USB inserito: " + deviceID);
            // Puoi filtrare ulteriormente per identificare le chiavette USB
        }

        private void DeviceRemovedEvent(object sender, EventArrivedEventArgs e)
        {
            var instance = (ManagementBaseObject)e.NewEvent["TargetInstance"];
            string deviceID = (string)instance["DeviceID"];
            Console.WriteLine("USB rimosso: " + deviceID);
            // Puoi filtrare ulteriormente
        }
    }
}
