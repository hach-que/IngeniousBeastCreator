//
// This source code is licensed in accordance with the licensing outlined
// on the main Tychaia website (www.tychaia.com).  Changes to the
// license on the website apply retroactively.
//
using System;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace IngeniousBeastCreator
{
    [Serializable]
    public class Beast
    {
        public string Name;

        public Heart Heart;

        public Beast(string name)
        {
            this.Name = name;
        }

        public void Customize()
        {
            this.Heart = new Heart();
            this.Heart.Capacity = this.PromptInt("Enter the capacity of " + this.Name + "'s heart");
        }

        public void Save()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(this.Name + ".bin", 
                                     FileMode.Create, 
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public int PromptInt(string prompt)
        {
            Console.Write(prompt + ": ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}

