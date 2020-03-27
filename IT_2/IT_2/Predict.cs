using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_2
{   
    class Predict
    {
        private double[] record, noise, error, filter, signalNoise, gaussElement;
        private int[] info;
        private int size, leftrange, rightrange, element = 15, noisePercent, filterLength;
        private double signal_en, summ, noise_en, sumSquare, coef1, coef2, edge;
        private double freq1, freq2, freq3;
        public int leftPred, rightPred;
        Random rand;

        public Predict(int size, int leftrange, int rightrange, int noisePercent, int filterLength, double edge, double[] freqArray)
        {
            this.size = size;
            this.leftrange = leftrange;
            this.rightrange = rightrange;
            freq1 = freqArray[0];
            freq2 = freqArray[1];
            freq3 = freqArray[2];
            this.noisePercent = noisePercent;
            this.filterLength = filterLength;
            this.edge = edge;

            record = new double[this.size];
            noise = new double[this.size];
            filter = new double[this.size];
            error = new double[this.size];
            info = new int[2];

            signalNoise = new double[this.size];
            gaussElement = new double[element];


            rand = new Random();
        }

        public double[] Draw()
        {
            for (int i = 0; i < leftrange; i++)
            {
                record[i] = Math.Sin(freq1 * i);
            }
            for (int i = leftrange; i < rightrange; i++)
            {
                record[i] = Math.Sin(freq1 * leftrange + (i - leftrange) * freq2);
            }
            for (int i = rightrange; i < size; i++)
            {
                record[i] = Math.Sin(freq1 * leftrange + (rightrange - leftrange) * freq2 + (i - rightrange) * freq3);
            }

            AddNoise();

            return record;
        }

        private void AddNoise()
        {
            for (int i = 0; i < size; i++)
            {
                signalNoise[i] = 0;
                for (int j = 0; j < element; j++)
                {
                    gaussElement[j] = GetRandom(-1, 1);
                    signalNoise[i] += gaussElement[j];
                }
                signalNoise[i] /= element;
            }

            for (int i = 0; i < size; i++)
            {
                signal_en += (record[i] * record[i]);
                summ += (signalNoise[i] * signalNoise[i]);
            }

            noise_en = noisePercent * signal_en / 100; //энергия шума
            double alpha = Math.Sqrt(noise_en / summ);

            //прибавляем шум к основному сигналу
            for (int i = 0; i < size; i++)
            {
                record[i] = record[i] + alpha * signalNoise[i];
            }
        }

        public double[] DrawError()
        {
            coef1 = -2 * Math.Cos(freq2);
            coef2 = 1;

            for (int i = 2; i < size; i++)
            {
                error[i] = record[i] + coef1 * record[i - 1] + coef2 * record[i - 2];
            }

            for (int i = 0; i < size; i++)
            {
                error[i] = Math.Abs(Math.Pow(error[i], 2));
            }

            return error;
        }

        public double[] DrawFilter()
        {
            for (int k = (filterLength - 1) / 2; k < size - (filterLength - 1) / 2; k++)
            {
                for (int i = -(filterLength - 1) / 2; i < (filterLength - 1) / 2; i++)
                {
                    filter[k] += error[k - i] / filterLength;
                }
            }

            for (int i = 0; i < (filterLength - 1) / 2; i++)
            {
                filter[i] = filter[(filterLength - 1) / 2];
            }

            for (int i = size - (filterLength - 1) / 2; i < size; i++)
            {
                filter[i] = filter[size - 1 - (filterLength - 1) / 2];
            }
            
            try
            {
                int step1 = 1; //начало
                do
                {
                    leftPred = step1;
                    step1++;
                } while (filter[step1] > edge);

                int step2 = size - 1; //конец

                do
                {
                    rightPred = step2;
                    step2--;
                } while (filter[step2] > edge);
            }
            catch(Exception)
            {
                MessageBox.Show("ЗАЧЕМ ТАКОЙ БОЛЬШОЙ ШУМ, АААААААААААААААА!!1", "ТЫ ОБОСРАЛСЯ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            info[0] = leftPred;
            info[1] = rightPred;

            return filter;
        }

        private double GetRandom(double minimum, double maximum)
        {
            return rand.NextDouble() * (maximum - minimum) + minimum;
        }

        public int[] GetPredicted()
        {
            return info;
        }
    }
}
