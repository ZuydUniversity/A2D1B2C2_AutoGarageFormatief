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
                                Console.WriteLine($"    {i}. Commercial vehicle: Licenseplate: {commercialVehicle.LicensePlate}, Description: {commercialVehicle.Description}, Towing weight: {commercialVehicle.TowingWeight}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"    {i}. Licenseplate: {vehicle.LicensePlate}, Description: {vehicle.Description}");
                        }
                    }
                }
            }

        }
    }
}