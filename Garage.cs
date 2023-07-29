using CarDealership.CarBrands;
using CarDealership.VehicleClasses;
using CarDealership.VehicleParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarDealership
{
    public class Garage
    {
        private VehicleManager _vm;
        public Garage(VehicleManager vm) 
        {
            _vm = vm;
        }
        public void ExecuteClientVehicleReplaceParts()
        {
            int choice, index;
            Random rand = new Random();
            
            CarBuilder builder = new CarBuilder();
            VehicleSupplier.BuildVehicle(builder, _vm.workingWithBrands[rand.Next(0, 3)]);
            AVehicle v = builder.GetProduct();
            PrintManager.IndreduceClientVehicle();
            v.DisplayInfo();

            PrintManager.PartCatalog();
            choice = int.Parse(Console.ReadLine());
            List<AVehiclePart> reqParts = GetAvailableBrandParts(choice);
            PrintPartList(reqParts);

            PrintManager.AskVehicleChange();
            index = int.Parse(Console.ReadLine());
            ChangePart(choice, v, reqParts, index);

            PrintManager.VehicleAfterChange();
            v.DisplayInfo();
        }
        public List<AVehiclePart> GetAvailableBrandParts(int choice)
        {
            List<AVehiclePart> reqParts = new List<AVehiclePart>();
            if (choice == 1)
            {
                for (int i = 0; i < _vm.workingWithBrands.Length; i++)
                {
                    reqParts.AddRange(_vm.workingWithBrands[i].GetBrandParts("Engines"));
                }
            }
            else
            {
                for (int i = 0; i < _vm.workingWithBrands.Length; i++)
                {
                    reqParts.AddRange(_vm.workingWithBrands[i].GetBrandParts("Batterys"));
                }
            }
            return reqParts;
        }
        public void PrintPartList(List<AVehiclePart> partsList)
        {
            for (int i = 0; i < partsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {partsList[i].Name}");
            }
        }

        public void ChangePart(int choice, AVehicle vehicle, List<AVehiclePart> partsList, int index) 
        {
            if (choice == 1)
            {
                vehicle.VehicleEngine = (Engine)partsList[index - 1];
            }
            else
            {
                vehicle.VehicleBattery = (Battery)partsList[index - 1];
            }
        }
    }
}
