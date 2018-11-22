using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class SensorData
    {
        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string SensorName
        {
            get => _sensorname;
            set => _sensorname = value;
        }

        public int Temperature
        {
            get => _temperature;
            set => _temperature = value;
        }

        public int Co2
        {
            get => _co2;
            set => _co2 = value;
        }

        public SensorData(int id, string sensorname, int temperature, int co2)
        {
            _id = id;
            _sensorname = sensorname;
            _temperature = temperature;
            _co2 = co2;
        }

        public override string ToString()
        {
            return $"Room Name: {SensorName}. Temp reading: {Temperature}. CO2 reading {Co2}";
        }

        private int _id;
        private string _sensorname;
        private int _temperature;
        private int _co2;
    }
}
