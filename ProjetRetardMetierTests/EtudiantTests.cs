using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetRetardMetier;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetRetardMetier.Tests
{
    [TestClass()]
    public class EtudiantTests
    {
        [TestMethod()]
        public void GetNbRetardExcusesTest()
        {
            Etudiant et1 = new Etudiant(1, "Enzo");

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");
            Motif motif3 = new Motif(3, "Problème transport");

            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);
            Retard retard3 = new Retard(3, DateTime.Now.ToShortDateString(), motif3, true);

            et1.AjouterRetard(retard1); et1.AjouterRetard(retard2); et1.AjouterRetard(retard3);

            Assert.AreEqual(2, et1.GetNbRetardExcuses());
        }

        [TestMethod()]
        public void GetNbRetardMotifTest()
        {
            Etudiant et4 = new Etudiant(4, "Milo");

            Motif motif2 = new Motif(2, "Pas envie");
            Motif motif4 = new Motif(4, "RER A");
            Motif motif5 = new Motif(5, "Mariage de mon frère");

            Retard retard10 = new Retard(10, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard11 = new Retard(11, DateTime.Now.ToShortDateString(), motif5, false);
            Retard retard12 = new Retard(12, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard13 = new Retard(13, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard14 = new Retard(14, DateTime.Now.ToShortDateString(), motif5, false);
            Retard retard15 = new Retard(15, DateTime.Now.ToShortDateString(), motif2, true);

            et4.AjouterRetard(retard10); et4.AjouterRetard(retard11);
            et4.AjouterRetard(retard12); et4.AjouterRetard(retard13);
            et4.AjouterRetard(retard14); et4.AjouterRetard(retard15);

            Assert.AreEqual(3, et4.GetNbRetardMotif(motif4));
        }

        [TestMethod()]
        public void GetNbRetardTotalTest()
        {
            Etudiant et4 = new Etudiant(4, "Milo");

            Motif motif2 = new Motif(2, "Pas envie");
            Motif motif4 = new Motif(4, "RER A");
            Motif motif5 = new Motif(5, "Mariage de mon frère");

            Retard retard10 = new Retard(10, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard11 = new Retard(11, DateTime.Now.ToShortDateString(), motif5, false);
            Retard retard12 = new Retard(12, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard13 = new Retard(13, DateTime.Now.ToShortDateString(), motif4, false);
            Retard retard14 = new Retard(14, DateTime.Now.ToShortDateString(), motif5, false);
            Retard retard15 = new Retard(15, DateTime.Now.ToShortDateString(), motif2, true);

            et4.AjouterRetard(retard10); et4.AjouterRetard(retard11);
            et4.AjouterRetard(retard12); et4.AjouterRetard(retard13);
            et4.AjouterRetard(retard14); et4.AjouterRetard(retard15);

            Assert.AreEqual(6, et4.GetNbRetardTotal());
        }

        [TestMethod()]
        public void GetPourcentageRetardExcusesTest()
        {
            Etudiant et1 = new Etudiant(1, "Enzo");

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");
            Motif motif3 = new Motif(3, "Problème transport");

            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);
            Retard retard3 = new Retard(3, DateTime.Now.ToShortDateString(), motif3, true);

            et1.AjouterRetard(retard1); et1.AjouterRetard(retard2); et1.AjouterRetard(retard3);

            double pourcentage = Math.Round((double) 2 / 3 * 100, 2);

            Assert.AreEqual(pourcentage, et1.GetPourcentageRetardExcuses());
        }

        [TestMethod()]
        public void GetPourcentageRetardNonExcusesTest()
        {
            Etudiant et1 = new Etudiant(1, "Enzo");

            Motif motif1 = new Motif(1, "Malade grippe");
            Motif motif2 = new Motif(2, "Pas envie");
            Motif motif3 = new Motif(3, "Problème transport");

            Retard retard1 = new Retard(1, DateTime.Now.ToShortDateString(), motif1, false);
            Retard retard2 = new Retard(2, DateTime.Now.ToShortDateString(), motif2, true);
            Retard retard3 = new Retard(3, DateTime.Now.ToShortDateString(), motif3, true);

            et1.AjouterRetard(retard1); et1.AjouterRetard(retard2); et1.AjouterRetard(retard3);

            double pourcentage = Math.Round(100 - (double)2 / 3 * 100, 2);

            Assert.AreEqual(pourcentage, et1.GetPourcentageRetardNonExcuses());
        }
    }
}
