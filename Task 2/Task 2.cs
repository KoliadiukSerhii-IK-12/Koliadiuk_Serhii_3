using System;
using System.Collections.Generic;

namespace Task_2
{
    class Parcel
    {
        public Parcel()
        {
            this.price = 0;
            this.weight = 0;
            this.distance = 0;
            this.parcelSize = 0;
            this.parcelNumber = 0;

            this.parcelType = "none";
            this.placeOfReceipt = "none";
            this.placeOfDeparture = "none";
            this.currentLocationOfTheParcel = "none";
        }

        public Parcel(Parcel parcel)
        {
            this.price = parcel.price;
            this.weight = parcel.weight;
            this.distance = parcel.distance;
            this.parcelSize = parcel.parcelSize;
            this.parcelNumber = parcel.parcelNumber;

            this.parcelType = parcel.parcelType;
            this.placeOfDeparture = parcel.placeOfDeparture;
            this.placeOfReceipt = parcel.placeOfReceipt;
            this.currentLocationOfTheParcel = parcel.currentLocationOfTheParcel;
        }

        public Parcel(uint parcelNumber, double price, double weight, double parcelSize, double distance, string parcelType, string placeOfDeparture, string placeOfReceipt, string currentLocationOfTheParcel)
        {
            this.Price = price;
            this.Weight = weight;
            this.Distance = distance;
            this.ParcelSize = parcelSize;
            this.ParcelNumber = parcelNumber;

            this.ParcelType = parcelType;
            this.PlaceOfDeparture = placeOfDeparture;
            this.PlaceOfReceipt = placeOfReceipt;
            this.CurrentLocationOfTheParcel = currentLocationOfTheParcel;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"-------------Parcel# {this.ParcelNumber}--------------------");
            Console.WriteLine("Price: " + this.Price + "$");
            Console.WriteLine("Parcel size: " + this.ParcelSize);
            Console.WriteLine("Weight: " + this.Weight);
            Console.WriteLine("Parcel type: " + this.ParcelType);
            Console.WriteLine("Place of departure: " + this.PlaceOfDeparture);
            Console.WriteLine("Place of receipt: " + this.PlaceOfReceipt);
            Console.WriteLine("Distance: " + this.Distance);
            Console.WriteLine("Current location of the parcel: " + this.CurrentLocationOfTheParcel);
            Console.WriteLine("------------------------------------------\n");
        }

        public uint ParcelNumber
        {
            get { return parcelNumber; }
            set { if (value >= 0) { parcelNumber = value; } else { parcelNumber = 0; } }
        }

        public double Price
        {
            get { return price; }
            set { if (value >= 0) { price = value; } else { price = 0; } }
        }

        public double Weight
        {
            get { return weight; }
            set { if (value >= 0) { weight = value; } else { weight = 0; } }
        }

        public double ParcelSize
        {
            get { return parcelSize; }
            set { if (value >= 0) { parcelSize = value; } else { parcelSize = 0; } }
        }

        public double Distance
        {
            get { return distance; }
            set { if (value >= 0) { distance = value; } else { distance = 0; } }
        }

        public string ParcelType
        {
            get { return parcelType; }
            set { if (value.ToLower() == "ordinary" || value.ToLower() == "valuable") { parcelType = value; } else { parcelType = "ordinary"; } }
        }

        public string PlaceOfDeparture
        {
            get { return placeOfDeparture; }
            set { if (value.Length != 0) { placeOfDeparture = value; } else { placeOfDeparture = "none"; } }
        }

        public string PlaceOfReceipt
        {
            get { return placeOfReceipt; }
            set { if (value.Length != 0) { placeOfReceipt = value; } else { placeOfReceipt = "none"; } }
        }

        public string CurrentLocationOfTheParcel
        {
            get { return currentLocationOfTheParcel; }
            set { if (value.Length != 0) { currentLocationOfTheParcel = value; } else { currentLocationOfTheParcel = "none"; } }
        }

        private uint parcelNumber;
        private double price;
        private double weight;
        private double parcelSize;
        private double distance;
        private string parcelType;
        private string placeOfDeparture;
        private string placeOfReceipt;
        private string currentLocationOfTheParcel;
    }

    class PostCompany
    {
        public void Menu()
        {
            bool isNumber = false;
            int switch_on;
            do
            {
                do
                {
                    Console.Write("Choose an action:\n0 - Exit\n1 - Add parcel\n2 - Sort parcels by place of departure\n3 - Sort parcels by place of receipt\n4 - Show current location of the parcel\n5 - Show parcels lighter than twenty kilograms\n6 - Show all parcels\n");
                    isNumber = int.TryParse(Console.ReadLine(), out switch_on);
                } while (isNumber == false);


                switch (switch_on)
                {
                    case 0:
                        Console.WriteLine("Exit!\n");
                        break;
                    case 1:
                        AddParcel();
                        break;
                    case 2:
                        SortParcelsByPlaceOfDeparture();
                        ShowAllParcels();
                        break;
                    case 3:
                        SortParcelsByPlaceOfReceipt();
                        ShowAllParcels();
                        break;
                    case 4:
                        ShowAllParcels();
                        double number;
                        Console.Write("Enter the number of the parcel: ");
                        number = double.Parse(Console.ReadLine());
                        foreach (var item in parcels)
                        {
                            if (item.ParcelNumber == number)
                            {
                                Console.WriteLine(GetCurrentLocationOfTheParcel(item));
                                goto Break;
                            }
                        }
                        Console.WriteLine("No such parcel!");
                    Break:
                        break;
                    case 5:
                        ShowParcelsLighterThanTwentyKilograms();
                        break;
                    case 6:
                        ShowAllParcels();
                        break;
                    default:
                        Console.WriteLine("No such variant! Try again.");
                        break;
                }
            } while (switch_on != 0);
        }
        public void AddParcel()
        {
            double price, weight, parcelSize, distance;
            string parcelType, placeOfDeparture, placeOfReceipt, currentLocationOfTheParcel;
            Parcel newParcel = new Parcel();
            newParcel.ParcelNumber = this.ParcelNumber;

            Console.Write("Enter the weight of the parcel: ");
            weight = double.Parse(Console.ReadLine());
            newParcel.Weight = weight;

            Console.Write("\nEnter the parcel size: ");
            parcelSize = double.Parse(Console.ReadLine());
            newParcel.ParcelSize = parcelSize;

            Console.Write("\nEnter the parcel type: ");
            parcelType = Console.ReadLine();
            newParcel.ParcelType = parcelType;

            Console.Write("\nEnter the place of departure of the parcel: ");
            placeOfDeparture = Console.ReadLine();
            newParcel.PlaceOfDeparture = placeOfDeparture;

            Console.Write("\nEnter the place of receipt of the parcel: ");
            placeOfReceipt = Console.ReadLine();
            newParcel.PlaceOfReceipt = placeOfReceipt;

            Console.Write("\nEnter the distance from the place of departure to the place of issue: ");
            distance = double.Parse(Console.ReadLine());
            newParcel.Distance = distance;

            Console.Write("\nEnter the current location of the parcel: ");
            currentLocationOfTheParcel = Console.ReadLine();
            newParcel.CurrentLocationOfTheParcel = currentLocationOfTheParcel;

            price = distance * pricePerKilometer;
            newParcel.Price = price;
            parcels.Add(newParcel);
            this.ParcelNumber++;
        }

        public string GetCurrentLocationOfTheParcel(Parcel parcel)
        {
            return parcel.CurrentLocationOfTheParcel;
        }

        public void SortParcelsByPlaceOfDeparture()
        {
            parcels.Sort((parcel1, parcel2) => parcel1.PlaceOfDeparture.CompareTo(parcel2.PlaceOfDeparture));
        }

        public void SortParcelsByPlaceOfReceipt()
        {
            parcels.Sort((parcel1, parcel2) => parcel1.PlaceOfReceipt.CompareTo(parcel2.PlaceOfReceipt));
        }

        public void ShowParcelsLighterThanTwentyKilograms()
        {
            foreach (Parcel parcel in parcels)
            {
                if (parcel.Weight < 20)
                    parcel.ShowInfo();
            }
        }

        public void ShowAllParcels()
        {
            foreach (Parcel parcel in parcels)
                parcel.ShowInfo();
        }

        private uint ParcelNumber = 1;
        private double pricePerKilometer = 0.2;
        private List<Parcel> parcels = new List<Parcel>();
    }

    class Program
    {
        static void Main(string[] args)
        {
            PostCompany NovaPoshta = new PostCompany();
            NovaPoshta.Menu();
        }
    }
}
