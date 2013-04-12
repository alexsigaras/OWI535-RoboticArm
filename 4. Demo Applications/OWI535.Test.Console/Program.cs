// (c) Copyright Alexandros Sigaras.
// OWI 535 Robotic Arm Library
// Test Console Application
// Project Website: https://github.com/alexsigaras/OWI535-RoboticArm
//
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;
using System.Threading;
using OWI535.Library;


namespace OWI535.Test.Console
{
    class Program
    {
        public static ArmController arm = new ArmController(4711, 0, 0);

        static void Main(string[] args)
        {
            int miliseconds = 1000;
            arm.ArmDown(miliseconds);
            arm.ArmUp(miliseconds);
            arm.RotateLeft(miliseconds);
            arm.RotateRight(miliseconds);
            arm.ClawClose(miliseconds);
            arm.ClawDown(miliseconds);
            arm.ClawOpen(miliseconds);
            arm.ClawUp(miliseconds);
            arm.ElbowDown(miliseconds);
            arm.ElbowUp(miliseconds);
            arm.LightOn();
            Thread.Sleep(2000);
            arm.LightOff();
        }
    }
}
