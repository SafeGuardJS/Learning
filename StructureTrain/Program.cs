//Требуется: Описать структуру с именем Train, содержащую следующие поля: название пункта
//назначения, номер поезда, время отправления.
//Написать программу, выполняющую следующие действия:
//- ввод с клавиатуры данных в массив, состоящий из восьми элементов типа Train(записи должны быть
//упорядочены по номерам поездов);
//- вывод на экран информации о поезде, номер которого введен с клавиатуры(если таких поездов нет,
//вывести соответствующее сообщение). 
using System;

namespace StructureTrain
{
    class Program
    {
        struct Train
        {
            string destinationName;
            int trainNumber;
            byte departureTimeMinutes;
            byte departureTimeHours;

            public string DestinationName
            {
                get { return destinationName; }
            }

            public int TrainNumber
            {
                get { return trainNumber; }
            }

            public byte DepartureTimeMinutes
            {
                set { departureTimeMinutes = value; }
                get { return departureTimeMinutes; }
            }

            public byte DepartureTimeHourse
            {
                set { DepartureTimeHourse = value; }
                get { return departureTimeHours; }
            }

            public Train(int trainNumber, string destinationName, byte departureTimeHours, byte departureTimeMinutes )
            {
                this.trainNumber = trainNumber;
                this.destinationName = destinationName;

                if (departureTimeHours >= 0 && departureTimeHours < 24)
                    this.departureTimeHours = departureTimeHours;
                else
                {
                    this.departureTimeHours = -0;
                    Console.WriteLine("Hour's value is invalid!");
                }

                if (departureTimeMinutes >= 0 && departureTimeMinutes < 60)
                    this.departureTimeMinutes = departureTimeMinutes;
                else
                {
                    this.departureTimeMinutes = -0;
                    Console.WriteLine("Minute's value is invalid!");
                }
            }

        }

        class TrainList
        {
            Train[] comingTrains = new Train[1];

            public TrainList()
            {
                for(int i = 0; i < comingTrains.Length; i++)
                {
                    int trainNumber;
                    string destinationName;
                    byte departureTimeHours;
                    byte departureTimeMinutes;

                    Console.WriteLine("Enter train number: ");
                    trainNumber = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("Enter destination name: ");
                    destinationName = Console.ReadLine();

                    Console.WriteLine("Enter departure hours: ");
                    departureTimeHours = Convert.ToByte(Console.ReadLine());

                    Console.WriteLine("Enter departure minutes: ");
                    departureTimeMinutes = Convert.ToByte(Console.ReadLine());
                    Console.Clear();

                    comingTrains[i] = new Train(trainNumber, destinationName, departureTimeHours, departureTimeMinutes);
                }
            }

            public string this[int index]
            {
                get
                {
                    foreach (Train i in comingTrains)
                        if (i.TrainNumber == index)
                            return GetSingleTrainInfo(i);
                    return "There are no trains by this number!";
                }
            }

            string GetSingleTrainInfo(Train train)
            {
                return train.TrainNumber + "\t" + train.DestinationName + "\t" + GetCommonValueTime(train.DepartureTimeHourse) + ":" + GetCommonValueTime(train.DepartureTimeMinutes);
            }

            public void GetExactTrainInfo(int num)
            {
                Console.WriteLine(this[num]);
            }
            
            public void GetComingTrainList()
            {
                SortTrainList(ref this.comingTrains);

                Console.Clear();
                foreach(Train i in comingTrains)
                    Console.WriteLine(GetSingleTrainInfo(i));
            }

            string GetCommonValueTime(byte num)
            {
                if (num < 10)
                    return "0" + num;
                else
                    return num.ToString();
            }



            void SortTrainList(ref Train[] train)
            {
                int Min;
                Train key;

                for (int i = 0; i < train.Length; i++)
                {
                    Min = i;

                    for (int j = i + 1; j < train.Length; j++)
                    {
                        if (train[Min].TrainNumber > train[j].TrainNumber)
                        {
                            Min = j;
                        }
                    }

                    key = train[i];
                    train[i] = train[Min];
                    train[Min] = key;
                }
            }
        }

        static void Main(string[] args)
        {
            TrainList kievStation = new TrainList();

            kievStation.GetComingTrainList();


            Console.WriteLine("Enter train nubmer which you want to get info: ");
            kievStation.GetExactTrainInfo(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
