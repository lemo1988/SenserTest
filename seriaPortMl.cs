using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace UpperComputer
{
   public class SeriaPortMl : SerialPort
    {
        public SeriaPortMl(string portNameMl, int burdRateMl, string parityMl,int dataBitsMl,string stopBitsMl)
        {
            try
            {
                PortName = portNameMl;
                BaudRate = burdRateMl;
                DataBits = dataBitsMl;
                StopBits = SetStopBits(stopBitsMl);
                Parity = SetParity(parityMl);
            }
            catch (Exception )
            {
                MessageBox.Show("串口号为空!");
            }
        }
        /// <summary>
        /// 校验位设置
        /// </summary>
        /// <param name="ParityMl"></param>
        /// <returns></returns>
        private Parity SetParity(string ParityMl)
        {
            switch (ParityMl)
            {
                case "0": return Parity.None; 
                case "1": return Parity.Odd; 
                case "2": return Parity.Even; 
                default: return Parity.Odd;
            }
        }
        /// <summary>
        /// 停止位设置
        /// </summary>
        /// <param name="StopBitsMl"></param>
        /// <returns></returns>
       private StopBits SetStopBits(string StopBitsMl)
        {
            switch (StopBitsMl)
            {
                case "1": return StopBits.One; 
                case "2": return StopBits.OnePointFive; 
                default:
                    return StopBits.One;
            }
        }
    }
}
