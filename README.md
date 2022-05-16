# CD8-T-cells
Here we present the source code that implements a genetic regulatory network for the paper entitled: 
"Metabolic alterations impair differentiation and effector functions of CD8+ T cells" 
Authors: Antonio Bensussen1, Angélica Santana2, Otoniel Rodríguez-Jorge2*
1Laboratorio de Dinámica de Redes Genéticas, Centro de Investigación en Dinámica Celular, Universidad Autónoma del Estado de Morelos, Cuernavaca, México.
2Laboratorio de Inmunología, Centro de Investigación en Dinámica Celular, Universidad Autónoma del Estado de Morelos, Cuernavaca, México.

*Importantly: this solution is a Console project that must be runned in Microsoft Visual Studio 2022. The code was written using C#, and feel to modified if needed.
*To run this solution, you need to install Visual Studio 2022, then create a blanck solution, copy and paste the code, change the path (i.e. string filepath = @"C:\Users\anton\OneDrive\Escritorio\CD8_T_cells.txt";) to your desktop, and run it.

Algorithm summarized: 1) First the program generates all possible initial conditions of the network (in this case 262144 initial states). 2) Then, the program uses each of the initial states to execute a numerical synchronous simulation of the gene regulatory network. 3) Later, the program check wheter the simulation reaches an attractor or not. 4) Then, the program counts how many times one specific attractor was reached. 5) Finally, the program write a text file with the attractors found with their corresponding frequencies. To simulate a phenotype such as Tc1, you must set 1 in the input section corresponding to IFNGe and IL12e. This is the same for other phenotypes described in the paper.  
