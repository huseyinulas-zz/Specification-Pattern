using System;
using System.Collections.Generic;

using Specification.Core;
using Specification.Specifications;

namespace Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleRoomCount = 5;
            var hotelRepository = new HotelRepository();

            List<Hotel> hotels = hotelRepository.GetAll();

            ISpecification<Hotel> boutiqueHotelSpesification = new BoutiqueHotelSpesification();
            ISpecification<Hotel> fiveStarSpesification = new FiveStarSpesification();
            ISpecification<Hotel> emptyRoomCountSpesification = new EmptyRoomSpecification(peopleRoomCount);

            foreach (Hotel hotel in hotels)
            {
                bool boutiqueSpec = boutiqueHotelSpesification.IsSatisfiedBy(hotel);
                bool fiveStarSpec = fiveStarSpesification.IsSatisfiedBy(hotel);
                bool enoughRoomSpec = emptyRoomCountSpesification.IsSatisfiedBy(hotel);
                Console.WriteLine($"Hotel Name: {hotel.Name} - Boutique Hotel: {boutiqueSpec} - Luxury Hotel: {fiveStarSpec} - Can Booked: {enoughRoomSpec}");
            }

            Console.WriteLine();

            ISpecification<Hotel> complexSpecification = new BoutiqueHotelSpesification().And(new FiveStarSpesification()).And(new EmptyRoomSpecification(peopleRoomCount));

            foreach (Hotel hotel in hotels)
            {
                bool satisfyAllSpecs = complexSpecification.IsSatisfiedBy(hotel);
                if (satisfyAllSpecs)
                {
                    Console.WriteLine($"For 5 People, 5 Star, Boutique Hotel: {hotel.Name}");
                }
            }
        }
    }
}
