using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace ClassLibraryControlRestore
{
    public partial class ComponentRestore : Component
    {
        private string _path;

        public ComponentRestore()
        {
            InitializeComponent();
        }

        public ComponentRestore(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        /// <summary> 
        /// Путь до файла с бекапом 
        /// </summary>
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public void Save<T>(List<T> data)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(T[]));
            using (FileStream fileStream = new FileStream(_path, FileMode.Create))
            {
                jsonFormatter.WriteObject(fileStream, data.ToArray());
            }
        }

        public List<T> Restore<T>()
        {
            if (!typeof(T).IsSerializable) {
                throw new Exception($"Класс {typeof(T).Name} не сериализуем");
            }
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(T[]));
            List<T> restoredData = new List<T>();
            using (FileStream fileStream = new FileStream(_path, FileMode.OpenOrCreate))
            {
                T[] data = (T[])jsonFormatter.ReadObject(fileStream);
                restoredData.AddRange(data);
            }
            return restoredData;
        }
    }
}
