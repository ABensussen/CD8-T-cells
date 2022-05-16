// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

string filepath = @"C:\Users\anton\OneDrive\Escritorio\CD8_T_cells.txt";

//*****************
#region
Stopwatch timer = new Stopwatch();

//Step 1: Declaring control variables
List<string> intialConditions = new List<string>();
List<string> fixedPoints = new List<string>();
StreamWriter outcomeModel = new StreamWriter(filepath);

int numberNodes = 18;
int maxN = (int)Math.Pow(2, numberNodes);
int n = 0;
int iterationN = 10;

//Step 2: Creating all initial states of the network
for (int i = 0; i < maxN; i++)
{
    n = i;
    string bin = Convert.ToString(n, 2).PadLeft(numberNodes, '0');
    intialConditions.Add(bin);
}
#endregion
//*****************
timer.Start();

//Step 4: Searching for the fixed points
for (int h = 0; h < maxN; h++)
{
    //*****************
    #region
    //Subprocess 1: Picking an initial condition
    string sentence = intialConditions[h];
    char[] charArr = sentence.ToCharArray();
    int[] xS = Array.ConvertAll(charArr, c => (int)Char.GetNumericValue(c));
    //Gene network

    int IL6e = 0;
    int IFNGe = 0;
    int IL2e = 0;
    int IL4e = 01;
    int IL10e = 0;
    int TGFB = 0;
    int IL12e = 01;
    int IFNI = 0;
    int aa = 0;
    int GFs = 0;
    int Glucose = 0;
    int PD1 = 0;
    int FFAs = 0;
    int IL15e = 0;
    int Ceramide = 0;
    int EtOH = 0;
    int FasL = 0;

    #region
    List<int> TBET = new List<int>();
    List<int> IFNG = new List<int>();
    List<int> GATA3 = new List<int>();
    List<int> IL4 = new List<int>();
    List<int> RORGT = new List<int>();
    List<int> IL10 = new List<int>();
    List<int> FOXP3 = new List<int>();
    List<int> FOXO1 = new List<int>();
    List<int> EOMES = new List<int>();
    List<int> mTORC1 = new List<int>();
    List<int> mTORC2 = new List<int>();
    List<int> ROS = new List<int>();
    List<int> AKT = new List<int>();
    List<int> GLUT4 = new List<int>();
    List<int> GranzymeB = new List<int>();
    List<int> SOD = new List<int>();
    List<int> BCL2 = new List<int>();
    List<int> CASP3 = new List<int>();


    TBET.Add(xS[0]);
    IFNG.Add(xS[1]);
    GATA3.Add(xS[2]);
    IL4.Add(xS[3]);
    RORGT.Add(xS[4]);
    IL10.Add(xS[5]);
    FOXP3.Add(xS[6]);
    FOXO1.Add(xS[7]);
    EOMES.Add(xS[8]);
    mTORC1.Add(xS[9]);
    mTORC2.Add(xS[10]);
    ROS.Add(xS[11]);
    AKT.Add(xS[12]);
    GLUT4.Add(xS[13]);
    GranzymeB.Add(xS[14]);
    SOD.Add(xS[15]);
    BCL2.Add(xS[16]);
    CASP3.Add(xS[17]);

    #endregion


    //Subprocess 2: Simulation of the boolean model

    #endregion
    //****************

    for (int u = 1; u < iterationN; u++)
    {
        //***********
        #region
        //Logic rule for TBET
        if (((IFNG[u - 1] == 1 || IFNI == 1 || (
            IL12e == 1 && !(
            IL6e == 1 ||
            IL4[u - 1] == 1 ||
            IL10[u - 1] == 1))) ||
            TBET[u - 1] == 1) && !(
            IL4[u - 1] == 1 ||
            GATA3[u - 1] == 1 ||
            IL6e == 1 ||
            FOXO1[u - 1] == 1)) { TBET.Add(1); }
        else { TBET.Add(0); }


        //Logic rule for IFNG
        if ((IFNGe == 1 || IFNI == 1 || ((
            IFNG[u - 1] == 1 ||
            TBET[u - 1] == 1 ||
            EOMES[u - 1] == 1) &&
            mTORC1[u - 1] == 1 && !(
            GATA3[u - 1] == 1 ||
            TGFB == 1))) && !(
            IL6e == 1 ||
            IL4[u - 1] == 1 ||
            IL10[u - 1] == 1)) { IFNG.Add(1); }
        else { IFNG.Add(0); }


        //Logic rule for GATA3
        if (((IL2e == 1 &&
            IL4[u - 1] == 1) ||
            EOMES[u - 1] == 1 ||
            GATA3[u - 1] == 1) && !(
            TBET[u - 1] == 1 ||
            TGFB == 1 ||
            IL6e == 1 ||
            IFNG[u - 1] == 1)) { GATA3.Add(1); }
        else { GATA3.Add(0); }


        //Logic rule for IL4
        if ((IL4e == 1 || (
            GATA3[u - 1] == 1 && (
            IL2e == 1 ||
            IL4[u - 1] == 1) &&
            TBET[u - 1] == 0)) && !(
            IFNG[u - 1] == 1 ||
            IL6e == 1)) { IL4.Add(1); }
        else { IL4.Add(0); }

        //Logic rule for RORGT
        if ((IL6e == 1 &&
            TGFB == 1) && !(
            TBET[u - 1] == 1 ||
            FOXP3[u - 1] == 1 ||
            GATA3[u - 1] == 1 ||
            FOXO1[u - 1] == 1)) { RORGT.Add(1); }
        else { RORGT.Add(0); }


        //Logic rule for IL10
        if ((IL10e == 1 ||
            EOMES[u - 1] == 1 || (
            IL10[u - 1] == 1 && (
            IFNG[u - 1] == 1 ||
            IL6e == 1 ||
            TGFB == 1 ||
            GATA3[u - 1] == 1))) &&
            mTORC1[u - 1] == 1) { IL10.Add(1); }
        else { IL10.Add(0); }


        //Logic rule for FOXP3
        if (((IL2e == 1 ||
            IL12e == 1) && (
            TGFB == 1 ||
            FOXP3[u - 1] == 1 ||
            IL4[u - 1] == 1 || (
            FOXO1[u - 1] == 1))) && !(
            IL6e == 1 ||
            RORGT[u - 1] == 1)) { FOXP3.Add(1); }
        else { FOXP3.Add(0); }


        //Logic rule for FOXO1
        if ((ROS[u - 1] == 1 ||
            FOXO1[u - 1] == 1) && !(
            mTORC1[u - 1] == 1 ||
            mTORC2[u - 1] == 1)) { FOXO1.Add(1); }
        else { FOXO1.Add(0); }


        //Logic rule for EOMES
        if ((ROS[u - 1] == 1 ||
            EOMES[u - 1] == 1 ||
            IFNI == 1 ||
            FOXO1[u - 1] == 1) &&
            mTORC2[u - 1] == 0) { EOMES.Add(1); }
        else { EOMES.Add(0); }


        //Logic rule for mTORC1
        if ((aa == 1 ||
            AKT[u - 1] == 1 ||
            ROS[u - 1] == 1 ||
            IL12e == 1 ||
            IL2e == 1) && !(
            mTORC2[u - 1] == 1 ||
            PD1 == 1 ||
            IL15e == 1)) { mTORC1.Add(1); }
        else { mTORC1.Add(0); }


        //Logic rule for mTORC2
        if ((GFs == 1 ||
            ROS[u - 1] == 1) &&
            mTORC1[u - 1] == 0) { mTORC2.Add(1); }
        else { mTORC2.Add(0); }


        //Logic rule for ROS
        if ((Glucose == 1 ||
            FFAs == 1 ||
            Ceramide == 1 ||
            EtOH == 1) &&
            SOD[u - 1] == 0) { ROS.Add(1); }
        else { ROS.Add(0); }


        //Logic rule for AKT
        if ((IFNG[u - 1] == 1 ||
            IL4[u - 1] == 1 ||
            IL10[u - 1] == 1 ||
            mTORC2[u - 1] == 1)) { AKT.Add(1); }
        else { AKT.Add(0); }


        //Logic rule for GLUT4
        if (AKT[u - 1] == 1 &&
            EOMES[u - 1] == 1 &&
            FOXO1[u - 1] == 0) { GLUT4.Add(1); }
        else { GLUT4.Add(0); }


        //Logic rule for GranzymeB
        if (TBET[u - 1] == 1 && !(
            GATA3[u - 1] == 1 ||
            RORGT[u - 1] == 1 ||
            FOXP3[u - 1] == 1 ||
            FOXO1[u - 1] == 1)) { GranzymeB.Add(1); }
        else { GranzymeB.Add(0); }


        //Logic rule for SOD
        if (ROS[u - 1] == 1 && (
            FOXO1[u - 1] == 1) &&
            Ceramide == 0) { SOD.Add(1); }
        else { SOD.Add(0); }


        //Logic rule for BCL2
        if ((FOXO1[u - 1] == 1) &&
            ROS[u - 1] == 0) { BCL2.Add(1); }
        else { BCL2.Add(0); }


        //Logic rule for CASP3
        if (FasL == 1 && (
            ROS[u - 1] == 1 ||
            CASP3[u - 1] == 1) &&
            BCL2[u - 1] == 0) { CASP3.Add(1); }
        else { CASP3.Add(0); }




        #endregion
    }

    //Subprocess 3: Saving data
    var node1 = TBET.Select(x => Convert.ToString(x)).ToList();
    var node2 = IFNG.Select(x => Convert.ToString(x)).ToList();
    var node3 = GATA3.Select(x => Convert.ToString(x)).ToList();
    var node4 = IL4.Select(x => Convert.ToString(x)).ToList();
    var node5 = RORGT.Select(x => Convert.ToString(x)).ToList();
    var node6 = IL10.Select(x => Convert.ToString(x)).ToList();
    var node7 = FOXP3.Select(x => Convert.ToString(x)).ToList();
    var node8 = FOXO1.Select(x => Convert.ToString(x)).ToList();
    var node9 = EOMES.Select(x => Convert.ToString(x)).ToList();
    var node10 = mTORC1.Select(x => Convert.ToString(x)).ToList();
    var node11 = mTORC2.Select(x => Convert.ToString(x)).ToList();
    var node12 = ROS.Select(x => Convert.ToString(x)).ToList();
    var node13 = AKT.Select(x => Convert.ToString(x)).ToList();
    var node14 = GLUT4.Select(x => Convert.ToString(x)).ToList();
    var node15 = GranzymeB.Select(x => Convert.ToString(x)).ToList();
    var node16 = SOD.Select(x => Convert.ToString(x)).ToList();
    var node17 = BCL2.Select(x => Convert.ToString(x)).ToList();
    var node18 = CASP3.Select(x => Convert.ToString(x)).ToList();

    List<string> Nodes = new List<string>();

    for (int w = 0; w < node1.Count; w++)
    {
        Nodes.Add(node1[w] + "  " +
            node2[w] + "  " +
            node3[w] + "  " +
            node4[w] + "  " +
            node5[w] + "  " +
            node6[w] + "  " +
            node7[w] + "  " +
            node8[w] + "  " +
            node9[w] + "  " +
            node10[w] + "  " +
            node11[w] + "  " +
            node12[w] + "  " +
            node13[w] + "  " +
            node14[w] + "  " +
            node15[w] + "  " +
            node16[w] + "  " +
            node17[w] + "  " +
            node18[w]);

    }
    // Subprocess 4: Identifying an attractor (fixed points only)
    for (int z = 0; z < Nodes.Count - 1; z++)
    {
        if (Nodes[z + 1] == Nodes[z])
        {
            fixedPoints.Add(Nodes[z]);
            break;
        }
    }

}

timer.Stop();

//Local
int Tc0Count = 0;
int Tc1Count = 0;
int Tc2Count = 0;
int Tc17Count = 0;
int TcReg = 0;
int NaiveCount = 0;
int EffectorCount = 0;
int MemoryCount = 0;
int AliveCount = 0;
int DeadCount = 0;
int Citotoxicity = 0;
//

if (fixedPoints.Count == 0) { fixedPoints.Add("null"); }

//Step 4: Calculating the size of the basin of attraction of each fixed point
var q = from x in fixedPoints
        group x by x into g
        let count = g.Count()
        orderby count descending
        select new { Value = g.Key, Count = count };

//Step 5: Presentation of results
outcomeModel.Write("      Nodes ID: {0  1  2  3  4  5  6  7  8  9  10 11 12 13 14 15 16 17}\n");

foreach (var x in q)
{
    Console.WriteLine("Fixed point in: {" + x.Value + "}  Size of its basin of attraction: {" + x.Count + "}");
    outcomeModel.Write("Fixed point in: {" + x.Value + "}  Size of its basin of attraction: {" + x.Count + "}\n");

    //classification and sum
    string ste = x.Value.Replace("  ", "");
    char[] Repase = ste.ToCharArray();
    Console.WriteLine(Repase.Length);

    if (Repase[0] == '0' && Repase[1] == '0' && Repase[2] == '0' && Repase[3] == '0' && Repase[4] == '0' && Repase[5] == '0' && Repase[6] == '0' && Repase[8] == '0')
    {
        Tc0Count = Tc0Count + x.Count;
    }
    if (Repase[0] == '1' && Repase[1] == '1' && Repase[5] == '0' && Repase[6] == '0' || Repase[0] == '0' && Repase[1] == '1' && Repase[5] == '0' && Repase[6] == '0' || Repase[0] == '1' && Repase[1] == '0' && Repase[5] == '0' && Repase[6] == '0')
    {
        Tc1Count = Tc1Count + x.Count;
    }
    if ((Repase[2] == '1' && Repase[3] == '1' && Repase[5] == '0' && Repase[6] == '0') || (Repase[2] == '1' && Repase[3] == '0' && Repase[5] == '0' && Repase[6] == '0') || (Repase[2] == '0' && Repase[3] == '1' && Repase[5] == '0' && Repase[6] == '0'))
    {
        Tc2Count = Tc2Count + x.Count;
    }
    if ((Repase[4] == '1'))
    {
        Tc17Count = Tc17Count + x.Count;
    }
    if ((Repase[5] == '1' && Repase[6] == '1') || (Repase[5] == '1' && Repase[6] == '0') || (Repase[5] == '0' && Repase[6] == '1'))
    {
        TcReg = TcReg + x.Count;
    }
    if (Repase[0] == '0' && Repase[1] == '0' && Repase[2] == '0' && Repase[3] == '0' && Repase[4] == '0' && Repase[5] == '0' && Repase[6] == '0' && Repase[8] == '0')
    {
        NaiveCount = NaiveCount + x.Count;
    }
    if (!(Repase[0] == '0' && Repase[1] == '0' && Repase[2] == '0' && Repase[3] == '0' && Repase[4] == '0' && Repase[5] == '0' && Repase[6] == '0' && Repase[8] == '0') && !(Repase[7] == '1' && Repase[8] == '1'))
    {
        EffectorCount = EffectorCount + x.Count;
    }
    if (Repase[7] == '1' && Repase[8] == '1')
    {
        MemoryCount = MemoryCount + x.Count;
    }
    if (Repase[17] == '0')
    {
        AliveCount = AliveCount + x.Count;
    }
    if (Repase[17] == '1')
    {
        DeadCount = DeadCount + x.Count;
    }
    if (Repase[14] == '1')
    {
        Citotoxicity = Citotoxicity + x.Count;
    }


} //maxN.ToString()

//write
outcomeModel.Write("\n");
outcomeModel.Write("\n");

outcomeModel.WriteLine("Tc0: " + Tc0Count);
outcomeModel.WriteLine("Tc1: " + Tc1Count);
outcomeModel.WriteLine("Tc2: " + Tc2Count);
outcomeModel.WriteLine("Tc17: " + Tc17Count);
outcomeModel.WriteLine("TcReg: " + TcReg);
outcomeModel.WriteLine("Naïve: " + NaiveCount);
outcomeModel.WriteLine("Effector: " + EffectorCount);
outcomeModel.WriteLine("Memory: " + MemoryCount);
outcomeModel.WriteLine("Alive: " + AliveCount);
outcomeModel.WriteLine("Dead: " + DeadCount);
outcomeModel.WriteLine("Citotoxic: " + Citotoxicity);

outcomeModel.Write("\n");


outcomeModel.Write("\n");
outcomeModel.Write("Total amount of initial states: " + maxN.ToString());
outcomeModel.Write("\n");
outcomeModel.Write("Legend:\n");
outcomeModel.Write("\n");
outcomeModel.Write(" TBET: {0}\n IFNG: {1}\n GATA3: {2}\n IL4: {3}\n RORGT: {4}\n");
outcomeModel.Write(" IL10: {5}\n FOXP3: {6}\n FOXO1: {7}\n EOMES: {8}\n mTORC1: {9}\n");
outcomeModel.Write(" mTORC2: {10}\n ROS: {11}\n AKT: {12}\n GLUT4: {13}\n GranzymeB: {14}\n SOD: {15}\n BCL2: {16}\n CASP3: {17}\n");
outcomeModel.Close();
Console.WriteLine(" ");
Console.WriteLine("The report is ready");
Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss\\.fffff} s", timer.Elapsed);
