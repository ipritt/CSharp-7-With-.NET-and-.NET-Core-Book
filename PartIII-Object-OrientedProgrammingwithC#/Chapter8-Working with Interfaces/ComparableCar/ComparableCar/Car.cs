﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableCar
{
    class Car
    {
        //  Constant for maximum speed.
        public const int MaxSpeed = 100;

        //  Car properties.
        public int CurrSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
        public int CarID { get; set; }

        //  Is the car still operational?
        private bool carIsDead;

        //  A car has-a radio.
        private Radio theMusicBox = new Radio();

        //  Constructors.
        public Car(){ }
        public Car(string name, int speed)
        {
            CurrSpeed = speed;
            PetName = name;
        }
        public Car(string name, int currSp, int id)
        {
            CurrSpeed = currSp;
            PetName = name;
            CarID = id;
        }

        public void CrankTunes(bool state)
        {
            //  Delegate request to inner object.
            theMusicBox.TurnOn(state);
        }

        //  See if the Car has overheated.
        public void Accelerate(int delta)
        {
            if (delta < 0)
                throw new ArgumentOutOfRangeException("delta", "Speed must be greater than zero!");
            if(carIsDead)
                Console.WriteLine("{0} is out of order...", PetName);
            else
            {
                CurrSpeed += delta;
                if(CurrSpeed > MaxSpeed)
                {
                    //Console.WriteLine("{0} has overheated!", PetName);
                    CurrSpeed = 0;
                    carIsDead = true;

                    // Throw the custom CarIsDeadException.
                    //CarIsDeadException ex = new CarIsDeadException($"{PetName} has overheated!",
                    //                                               "You have a lead foot", DateTime.Now);
                    //ex.HelpLink = "http://www.CarsRUs.com";
                    //throw ex;
                }
                else
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrSpeed);
            }
        }
    }
}
