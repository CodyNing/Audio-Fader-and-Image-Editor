using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Wave
    {

        public string ChunkID { get; private set;}

        public int ChunkSize { get; private set;}

        public string Format { get; private set;}

        public string Subchunk1ID { get; private set; }

        public int SubChunk1Size { get; private set;}

        public short AudioFormat { get; private set;}

        public short NumChannels { get; private set;}

        public int SampleRate { get; private set;}

        public int ByteRate { get; private set;}

        public short BlockAlign { get; private set;}

        public short BitsPerSample { get; private set;}

        public string SubChunk2ID { get; private set;}

        public int SubChunk2Size { get; private set;}

        public double[] LeftChannel { get; private set;}

        public double[] RightChannel { get; private set;}

        public double[] LeftChannelFaded { get; private set; }

        public double[] RightChannelFaded { get; private set; }

        public int Samples { get; private set; }


        static double BytesToDouble(byte firstByte, byte secondByte)
        {
            short s = ByteToShort(firstByte, secondByte);
            return s / 32768.0;
        }

        static short ByteToShort(byte firstByte, byte secondByte)
        {
            return (short)((secondByte << 8) | firstByte);
        }

        public static void FadeTransform(Wave wave) {

            wave.LeftChannelFaded = new double[wave.Samples];

            if (wave.NumChannels == 2)
            {
                wave.RightChannelFaded = new double[wave.Samples];
            }

            int half = wave.Samples / 2;

            double level = 20 / (double)half;

            double dbinit = -20;

            for (int i = 0; i < half; ++i)
            {
                double db = dbinit + i * level;
                double ratio = Math.Pow(10, db / 20);

                wave.LeftChannelFaded[i] = wave.LeftChannel[i] * ratio;

                if (wave.NumChannels == 2)
                {
                    wave.RightChannelFaded[i] = wave.RightChannel[i] * ratio;
                }
            }

            dbinit = 0;

            for (int i = half; i < wave.Samples; ++i)
            {
                double db = dbinit - (i - half) * level;

                double ratio = Math.Pow(10, db / 20);

                wave.LeftChannelFaded[i] = wave.LeftChannel[i] * ratio;

                if (wave.NumChannels == 2)
                {
                    wave.RightChannelFaded[i] = wave.RightChannel[i] * ratio;
                }
            }
        }

        public static Wave OpenWav(string filename)
        {
            var wave = new Wave();

            byte[] wav = File.ReadAllBytes(filename);

            wave.ChunkID = BitConverter.ToString(wav, 0, 4);

            wave.ChunkSize = BitConverter.ToInt32(wav, 4);

            wave.Format = BitConverter.ToString(wav, 8, 4);

            wave.Subchunk1ID = BitConverter.ToString(wav, 12, 4);

            wave.SubChunk1Size = BitConverter.ToInt32(wav, 16);

            wave.AudioFormat = BitConverter.ToInt16(wav, 20);

            wave.NumChannels = BitConverter.ToInt16(wav, 22);

            wave.SampleRate = BitConverter.ToInt32(wav, 24);

            wave.ByteRate = BitConverter.ToInt32(wav, 28);

            wave.BlockAlign = BitConverter.ToInt16(wav, 32);

            wave.BitsPerSample = BitConverter.ToInt16(wav, 34);

            wave.SubChunk2ID = BitConverter.ToString(wav, 36, 4);

            wave.SubChunk2Size = BitConverter.ToInt32(wav, 40);

            wave.Samples = wave.SubChunk2Size / (wave.BitsPerSample / 8) / wave.NumChannels;

            wave.LeftChannel = new double[wave.Samples];

            if(wave.NumChannels == 2)
            {
                wave.RightChannel = new double[wave.Samples];
            }

            for (int i = 0, pos = 44;  i < wave.Samples; ++i)
            {
                wave.LeftChannel[i] = BytesToDouble(wav[pos], wav[pos + 1]);
                pos += 2;
                if (wave.NumChannels == 2)
                {
                    wave.RightChannel[i] = BytesToDouble(wav[pos], wav[pos + 1]);
                    pos += 2;
                }
            }

            FadeTransform(wave);

            return wave;
        }
    }
}
