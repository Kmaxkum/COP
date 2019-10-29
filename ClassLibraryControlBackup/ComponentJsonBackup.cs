using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Json;

namespace ClassLibraryControlBackup
{
    public partial class ComponentJsonBackup : Component
    {
        public string OutputPath { get; set; }

        public void Backup(object[] items)
        {
            var ser = new DataContractJsonSerializer(items.GetType());
            //var path = Path.Combine(new []{OutputPath, $"{name}.json"});
            using (var fs = new FileStream(OutputPath, FileMode.OpenOrCreate))
            {
                ser.WriteObject(fs, items);
            }
        }

        public ComponentJsonBackup()
        {
            InitializeComponent();
        }

        public ComponentJsonBackup(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
