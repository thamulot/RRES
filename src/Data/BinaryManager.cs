using System;
using System.Collections.Generic;
using System.Text;
using NLog;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Reagan.Data
{
    public class BinaryManager
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Method used to serialize an object instance 
        /// to the specified file name.
        /// </summary>
        /// <param name="fileName">File name where to serialize</param>
        /// <param name="instance">Object instance to serialize</param>
        /// <returns>false if successfully done, true otherwise</returns>
        public static bool WriteFile(string fileName, Object instance)
        {
            bool ok = false;
            try
            {

                Stream stream = File.Open(fileName, FileMode.Create);
                BinaryFormatter bformatter = new BinaryFormatter();

                bformatter.Serialize(stream, instance);
                stream.Close();

                ok = true;
            }
            catch (Exception e)
            {
                logger.Error(e.ToString());
            }

            return !ok;
        }

        /// <summary>
        /// Method used to unserialize an object instance
        /// from an existing specified file name.
        /// </summary>
        /// <param name="fileName">XML file where the serialized object is</param>
        /// <returns>object instance if successfull, null otherwise</returns>
        public static Object ReadFile(string fileName)
        {
            try
            {
                //Open the file written above and read values from it.
                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();
                object value = bformatter.Deserialize(stream);
                stream.Close();
                return value;
            }
            catch (Exception e)
            {
                logger.Error(e.ToString());
            }
            return null;
        }
    }
}
