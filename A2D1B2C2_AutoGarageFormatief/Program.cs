using A2D1B2C2_AutoGarageFormatief.Model;

namespace A2D1B2C2_AutoGarageFormatief
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Autogarage");

            foreach (var owner in CarOwner.ReadCarOwners())
            {
                Console.WriteLine($"Owner: {owner.Name} (ID = {owner.Id})");
                if (owner.Vehicles != null )
                {
                    int i = 0;
                    foreach (var vehicle in owner.Vehicles)
                    {
                        i++;
                        if (vehicle is CommercialVehicle)
                        {
                            if (vehicle is CommercialVehicle commercialVehicle)
                            {
                                Console.WriteLine($"    {i}. Commercial vehicle: Licenseplate: {commercialVehicle.LicensePlate}, Description: {commercialVehicle.Description}, Towing weight: {commercialVehicle.TowingWeight} (ID = {commercialVehicle.Id})");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"    {i}. Licenseplate: {vehicle.LicensePlate}, Description: {vehicle.Description} (ID = {vehicle.Id})");
                        }
                    }
                }
            }

            // get vehicle to update
            int vehicleToUpdateId = 0;
            while (vehicleToUpdateId == 0)
            {
                try
                {
                    Console.WriteLine("Enter vehicle id to update: ");
                    var input = Console.ReadLine();
                    if (!string.IsNullOrEmpty(input))
                    {
                        vehicleToUpdateId = Int32.Parse(input);
                    }
                }
                catch (Exception)
                {
                    // do nothing, stay in loop                    
                }
            }
            Vehicle vehicleUpdate = Vehicle.ReadVehicleData(vehicleToUpdateId);
            
            // get new license plate
            string licensePlate = string.Empty;
            while (licensePlate == string.Empty)
            {
                try
                {
                    Console.WriteLine("Enter license plate: ");
                    licensePlate = Console.ReadLine();
                    vehicleUpdate.LicensePlate = licensePlate;
                    vehicleUpdate.UpdateVehicleData();                                        
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    licensePlate = string.Empty;
                    throw;                    
                }
            }

        }
    }
}