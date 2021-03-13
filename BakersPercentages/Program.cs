/***************************************************************
* Name        : BakersPercentages
* Author      : Anthony Hamlin
* Created     : 03/13/2021
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019 community
* Copyright   : 2021 MIT
*               specifications or project scope
* Description : This program take in user input
*               Flour weight along with a bread formula of water salt is the minimum input
*               The application converts the formula percentage values of the additional ingredients 
*               to grams bases on the flour weight       
***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakersPercentages
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBakersPercentages());
        }
    }
}
