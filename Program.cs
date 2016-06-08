
using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Monoalphabetic_cipher
{

    class Program
    {
        //The role of this program is to decrypt jpg image file corrupted by monoalphabetic method.
        //the meaning is that every value of byte was changed by a same constant number.
        //when the program will stop running, search in the folder that you have just created. 
        //you should be able to see clearly the decrypted photo.
        //Notice that 255 files will be created automatically during this process.
       static void Main(string[] args)
        {
           
                           
            for (int y = 0; y < 255; y++)
            {
              
                int key = y;

                using (FileStream stream2Read = File.OpenRead("wright the full path to the encrypted image here \\EncryptedImage.jpg"))
            {

                using (BinaryReader reader = new BinaryReader(stream2Read))
                {
                   
                    string sr = "wright the full path to the folder where new images will appear\\image_" + y + ".jpg";

                        using (FileStream stream2Write = File.Create(sr))
                        {

                            using (BinaryWriter writer = new BinaryWriter(stream2Write))
                            {                                
                                byte b;

                                for (int i = 1; i <= stream2Read.Length; i++)
                                {
                                    b = reader.ReadByte();                                  
                                    b = (byte)(b - key);
                                    writer.Write(b);

                                }
                            }
                        }
                    }
                }
            } 
        }
    }
}
