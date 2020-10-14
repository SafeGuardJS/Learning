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
            Train[] comingTrains = new Train[8];

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
                    for (int i = 0; i < this.comingTrains.Length; i++)
                        if (this.comingTrains[i].TrainNumber == index)
                            return GetSingleTrainInfo(i);
                    return "There are no trains by this number!";
                }
            }

            string GetSingleTrainInfo(int index)
            {
                return this.comingTrains[index].TrainNumber + "\t" + this.comingTrains[index].DestinationName + 
                        "\t" + GetCommonValueTime(this.comingTrains[index].DepartureTimeHourse) + 
                        ":" + GetCommonValueTime(this.comingTrains[index].DepartureTimeMinutes);
            }

            public void GetExactTrainInfo(int num)
            {
                Console.WriteLine(this[num]);
            }
            
            public void GetComingTrainList()
            {
                SortTrainList(ref this.comingTrains);

                Console.Clear();
                for(int i = 0; i < this.comingTrains.Length; i++)
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
