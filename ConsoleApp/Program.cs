using System;
using static System.Console;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // OddOccurancesInArray();
            // PermMissingElem();
            // TapeEquilibrium();
            // PermCheck();
            // FrogRiverOne();
            // MaxCounters();
            // MissingInteger();
            // PassingCars();
            //GenomicRangeQuery1();
            // MinAvgTwoSlice();
            //MinAvgTwoSliceWhile();
            //FindSlice();
            //CountDiv();
            // testArraySort();
            // Distinct();
            // Triangle();
            //MaxProductOfThree();
            // testSortAlgorithms();
            // NumberOfDiscIntersections();
            // Brackets();
            // Nesting();
            // StoneWall();
            // Fish();
            //  Leader();
            // EquiLeader();
            // Dominator();
            // MaxSliceSum();
            // MaxProfit();
            // MaxDoubleSliceSum();
            // CountFactors();
            // MinPerimeterRectangle();
            //Peaks();
            Flags();

        }
        static void OddOccurancesInArray()
        {
            int[] A = new int[] { 9, 7, 5, 7, 5, 8, 7, 9 };
            int number;
            WriteLine("[{0}]", string.Join(", ", A));

            OddOccurancesInArray sol = new OddOccurancesInArray();
            number = sol.solution(A);

            WriteLine(number);
        }

        static void PermMissingElem()
        {
            int N = 10;
            int[] A = new int[] { 7, 3, 6, 5, 10, 2, 9, 4, 8, 1 };


            int number;
            WriteLine("[{0}] N = {1}", string.Join(", ", A), N);

            PermMissingElem sol = new PermMissingElem();
            number = sol.solution(A, N);

            WriteLine(number);


        }

        static void TapeEquilibrium()
        {
            int[] A = new int[] { 3, 1, 2, 4, 3 };


            int number;
            WriteLine("[{0}]", string.Join(", ", A));

            TapeEquilibrium sol = new TapeEquilibrium();
            number = sol.solution(A);

            WriteLine(number);


        }

        static void PermCheck()
        {
            int[] A = new int[] { 3, 1, 2, 4 };

            int number;
            WriteLine("[{0}]", string.Join(", ", A));

            PermCheck sol = new PermCheck();
            number = sol.solution(A);

            WriteLine(number);


        }

        static void FrogRiverOne()
        {
            int[] A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            int X = 5;

            int number;
            WriteLine("[{0}]", string.Join(", ", A));

            FrogRiverOne sol = new FrogRiverOne();
            number = sol.solution(X, A);

            WriteLine(number);


        }

        static void MaxCounters()
        {
            int[] A = new int[] { 3, 4, 4, 6, 1, 4, 4 };
            int N = 5;
            int[] result;

            WriteLine("[{0}]", string.Join(", ", A));

            MaxCounters sol = new MaxCounters();
            result = sol.solution(N, A);

            WriteLine("[{0}]", string.Join(", ", result));

        }

        static void MissingInteger()
        {
            int[] A = new int[] { 1, 2, 3 };
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            MissingInteger sol = new MissingInteger();
            result = sol.solution(A);

            WriteLine("{0}", result);

        }

        static void PassingCars()
        {
            int[] A = new int[] { 0, 1, 0, 1, 1 };
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            PassingCars sol = new PassingCars();
            result = sol.solution(A);

            WriteLine("{0}", result);

        }

        static void GenomicRangeQuery()
        {
            string S = "CAGCCTA";
            int[] P = new int[] { 2, 5, 0 };
            int[] Q = new int[] { 4, 5, 6 };
            int[] result;

            WriteLine("{0}", S);
            WriteLine("[{0}]", string.Join(", ", P));
            WriteLine("[{0}]", string.Join(", ", Q));

            GenomicRangeQuery sol = new GenomicRangeQuery();
            result = sol.solution(S, P, Q);

            WriteLine("{0}", string.Join(", ", result));

        }

        static void GenomicRangeQuery1()
        {
            string S = "AC";
            int[] P = new int[] { 0, 0, 1 };
            int[] Q = new int[] { 0, 1, 1 };
            int[] result;

            WriteLine("{0}", S);
            WriteLine("[{0}]", string.Join(", ", P));
            WriteLine("[{0}]", string.Join(", ", Q));

            GenomicRangeQuery sol = new GenomicRangeQuery();
            result = sol.solution(S, P, Q);

            WriteLine("{0}", string.Join(", ", result));

        }

        static void MinAvgTwoSlice()
        {
            int[] A = new int[] { -46, 30, 76, 87, -14, 79, 31, 1, 75, -73, -28, -4, -68, -53, 36, -46, -75, -4, 85, -87 };

            // A = Generator.MinAvgTwoSlice1(10,-10000,10000);

            result r;
            TimeSpan t;
            DateTime st, end;

            WriteLine("[{0}]", string.Join(", ", A));

            MinAvgTwoSlice minavg = new MinAvgTwoSlice();

            st = DateTime.Now;
            r = minavg.solution(A);
            end = DateTime.Now;
            t = end - st;
            WriteLine($"Solution   Index:{r.index} Slice:{r.slice} Average:{r.average} Time:{t}");

            st = DateTime.Now;
            r = minavg.solution1(A);
            end = DateTime.Now;
            t = end - st;
            WriteLine($"Solution1  Index:{r.index} Slice:{r.slice} Average:{r.average} Time:{t}");

            st = DateTime.Now;
            r = minavg.solution2(A);
            end = DateTime.Now;
            t = end - st;
            WriteLine($"Solution2  Index:{r.index} Slice:{r.slice} Average:{r.average} Time:{t}");
        }

        static void MinAvgTwoSliceWhile()
        {
            int[] A = new int[] { 744, -8387, 9068, -8279, 2064, 22, -5427, 4865, -3048, -2723 };

            result r, r1, r2;
            TimeSpan t, t1, t2;
            DateTime st, end;
            bool stop = false;
            int count = 0;



            MinAvgTwoSlice minavg = new MinAvgTwoSlice();

            while (!stop)
            {
                A = Generator.MinAvgTwoSlice1(200, -1000, 1000);


                st = DateTime.Now;
                r = minavg.solution(A);
                end = DateTime.Now;
                t = end - st;

                st = DateTime.Now;
                r1 = minavg.solution1(A);
                end = DateTime.Now;
                t1 = end - st;

                st = DateTime.Now;
                r2 = minavg.solution2(A);
                end = DateTime.Now;
                t2 = end - st;

                if (r.index != r1.index || r.index != r2.index || count == 1000)
                {
                    WriteLine("[{0}]", string.Join(", ", A));
                    WriteLine($"Time: {t}   solution   :{r.index} ");
                    WriteLine($"Time: {t1}   solution2   :{r1.index} ");
                    WriteLine($"Time: {t2}   solution2   :{r2.index} ");

                    //stop = true;
                    count = 0;
                    ConsoleKeyInfo i = ReadKey();
                    if (i.KeyChar == 's')
                    {
                        stop = true;
                    }

                }
                // WriteLine("Time: {0}    solution   :{1} ", sol, result);
                count++;
            }


        }

        static void FindSlice()
        {
            int[] A = Generator.MinAvgTwoSlice1(10000, -1, 1);
            MinAvgTwoSlice minavg = new MinAvgTwoSlice();
            result res = new result { index = 0, slice = 2 };
            int i = 0;

            do
            {
                A = Generator.MinAvgTwoSlice1(1000, -10000, 10000);
                res = minavg.solution2(A);
                if (i > 100 || res.slice > 3)
                {
                    //WriteLine("[{0}]", string.Join(", ", A));
                    WriteLine("index:{0}   slice:{1} ", res.index, res.slice);
                    i = 0;
                }


                i++;
            } while (true);

        }

        static void CountDiv()
        {
            int A = 0,
                B = 14,
                K = 2;
            WriteLine("A = {0}, B = {1}, K = {2}", A, B, K);

            CountDiv coundDiv = new CountDiv();
            var result = coundDiv.solution(A, B, K);

            WriteLine("result = {0}", result);
        }

        static void testArraySort()
        {
            int[] A = new int[] { 3, 6, 1, 9, 2, 0, 5, 8, 7, 4, 4, 7, 8 };
            WriteLine("[{0}]", string.Join(", ", A));

            Sorting sort = new Sorting();
            sort.SelectionSort(A);

            WriteLine("Selection Sort: [{0}]", string.Join(", ", A));

            A = new int[] { 3, 6, 1, 9, 2, 0, 5, 8, 7, 4, 4, 7, 8 };
            sort.CountingSort(A);

            WriteLine("Counting Sort:  [{0}]", string.Join(", ", A));
        }

        static void Distinct()
        {
            int[] A = new int[] { 2, 1, 1, 2, 3, 1 };
            int result;
            WriteLine("[{0}]", string.Join(", ", A));

            Distinct dist = new Distinct();
            result = dist.solution(A);

            WriteLine("result : {0}", result);
        }

        static void Triangle()
        {
            int[] A = new int[] { 2147483647, 2147483647, 2147483647 };
            int result;
            WriteLine("[{0}]", string.Join(", ", A));

            Triangle dist = new Triangle();
            result = dist.solution(A);

            WriteLine("result : {0}", result);
        }

        static void MaxProductOfThree()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { -3, 1, 2, -2, 5, 6 };
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            MaxProductOfThree dist = new MaxProductOfThree();
            result = dist.solution1(A);
            WriteLine("solution1 result : {0}", result);

            result = dist.solution2(A);
            WriteLine("solution2 result : {0}", result);


        }

        static void testSortAlgorithms()
        {
            //int[] A = Generator.GenerateNumberArray(10,0,100);
            int[] A = new int[] { 3, 7, 8, 5, 2, 1, 9, 6, 4 };
            // WriteLine("[{0}]", string.Join(", ", A));
            // QuickSortAlgorithm alg = new QuickSortAlgorithm();
            // alg.quickSort(A,0,A.Length-1);
            // WriteLine("[{0}]", string.Join(", ", A));

            WriteLine("[{0}]", string.Join(", ", A));
            MergeSort alg = new MergeSort();
            int[] B = new int[A.Length];
            alg.TopDownMergeSort(A, B, A.Length);
            WriteLine("[{0}]", string.Join(", ", B));
        }

        static void NumberOfDiscIntersections()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { 1, 5, 2, 1, 4, 0 };
            //int[] A = new int[] {1, 2147483647, 0};
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            NumberOfDiscIntersections sol = new NumberOfDiscIntersections();
            result = sol.solution(A);
            WriteLine("solution result : {0}", result);

            result = sol.solution1(A);
            WriteLine("solution1 result : {0}", result);

            result = sol.solution2(A);
            WriteLine("solution2 result : {0}", result);
        }

        static void Brackets()
        {
            string s = "{[()()]}";

            WriteLine("{0}", s);
            Brackets sol = new Brackets();
            var result = sol.solution(s);
            WriteLine("solution result:{0}", result);
            result = sol.solution1(s);
            WriteLine("solution1 result:{0}", result);

        }

        static void Nesting()
        {
            string s = "(()(())())";

            WriteLine("{0}", s);
            Nesting sol = new Nesting();
            var result = sol.solution(s);
            WriteLine("solution result:{0}", result);
            result = sol.solution1(s);
            WriteLine("solution1 result:{0}", result);

        }

        static void StoneWall()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 };
            //int[] A = new int[] {1, 2147483647, 0};
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            StoneWall sol = new StoneWall();
            result = sol.solution(A);
            WriteLine("solution result : {0}", result);

            // result = sol.solution1(A);
            // WriteLine("solution1 result : {0}", result);

            // result = sol.solution2(A);
            // WriteLine("solution2 result : {0}", result);
        }

        static void Fish()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { 4, 3, 2, 1, 5 };
            int[] B = new int[] { 0, 1, 0, 0, 0 };
            int result;

            WriteLine("[{0}]", string.Join(", ", A));
            WriteLine("[{0}]", string.Join(", ", B));

            Fish sol = new Fish();
            result = sol.solution(A, B);
            WriteLine("solution result : {0}", result);

            // result = sol.solution1(A);
            // WriteLine("solution1 result : {0}", result);

            // result = sol.solution2(A);
            // WriteLine("solution2 result : {0}", result);
        }

        static void Leader()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { 6, 8, 4, 6, 8, 6, 6 };
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            Leader sol = new Leader();
            result = sol.slowLeader(A);
            WriteLine("slow result : {0}", result);

            // result = sol.fastLeader(A);
            // WriteLine("fast result : {0}", result);

            result = sol.stackLeader(A);
            WriteLine("stack result : {0}", result);
        }

        static void EquiLeader()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { 4, 3, 4, 4, 4, 2 };
            //int[] A = new int[] {1, 2, 3, 4, 5};
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            EquiLeader sol = new EquiLeader();
            result = sol.solution(A);
            WriteLine("solution result : {0}", result);

            result = sol.solution1(A);
            WriteLine("solution1 result : {0}", result);

        }

        static void Dominator()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { 3, 4, 3, 2, 3, -1, 3, 3 };
            //int[] A = new int[] {1, 2, 3, 4, 5};
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            Dominator sol = new Dominator();
            result = sol.solution(A);
            WriteLine("solution result : {0}", result);



        }

        static void MaxSliceSum()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { -10 };
            int[] B = new int[] { -2, 1 };
            int[] C = new int[] { 3, 2, -6, 4, 0 };
            int[] D = new int[] { -2, 1, 1 };
            int[] E = new int[] { -2, -2 };

            int result;

            WriteLine("A [{0}]", string.Join(", ", A));
            WriteLine("B [{0}]", string.Join(", ", B));
            WriteLine("C [{0}]", string.Join(", ", C));
            WriteLine("D [{0}]", string.Join(", ", D));
            WriteLine("E [{0}]", string.Join(", ", E));


            MaxSliceSum sol = new MaxSliceSum();
            result = sol.solution(A);
            WriteLine("solution A result : {0}", result);
            result = sol.solution1(A);
            WriteLine("solution1 A result : {0}", result);
            result = sol.solution2(A);
            WriteLine("solution2 A result : {0}", result);

            result = sol.solution(B);
            WriteLine("solution B result : {0}", result);
            result = sol.solution1(B);
            WriteLine("solution1 B result : {0}", result);
            result = sol.solution2(B);
            WriteLine("solution2 B result : {0}", result);

            result = sol.solution(C);
            WriteLine("solution C result : {0}", result);
            result = sol.solution1(C);
            WriteLine("solution1 C result : {0}", result);
            result = sol.solution2(C);
            WriteLine("solution2 C result : {0}", result);

            result = sol.solution(D);
            WriteLine("solution D result : {0}", result);
            result = sol.solution1(D);
            WriteLine("solution1 D result : {0}", result);
            result = sol.solution2(D);
            WriteLine("solution2 D result : {0}", result);

            result = sol.solution(E);
            WriteLine("solution E result : {0}", result);
            result = sol.solution1(E);
            WriteLine("solution1 E result : {0}", result);
            result = sol.solution2(E);
            WriteLine("solution2 E result : {0}", result);
        }

        static void MaxProfit()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { 23171, 21011, 21123, 21366, 21013, 21367 };
            int[] B = new int[] { 8, 9, 3, 6, 1, 2 };

            int result;

            WriteLine("[{0}]", string.Join(", ", A));
            WriteLine("[{0}]", string.Join(", ", B));

            MaxProfit sol = new MaxProfit();
            result = sol.solution(A);
            WriteLine("solution A result : {0}", result);

            result = sol.solution1(A);
            WriteLine("solution1 A result : {0}", result);

            result = sol.solution(B);
            WriteLine("solution B result : {0}", result);

            result = sol.solution1(B);
            WriteLine("solution1 B result : {0}", result);
        }

        static void MaxDoubleSliceSum()
        {
            //int[] A = Generator.GenerateNumberArray(100,-1000,1000);
            int[] A = new int[] { 3, 2, 6, -1, 4, 5, -1, 2 };
            int[] B = Generator.GenerateNumberArray(1000, -1000, 1000);
            int[] C = new int[] { 6, 1, 5, 6, 4, 2, 9, 4 };
            int result;

            WriteLine("A [{0}]", string.Join(", ", A));
            //WriteLine("B [{0}]", string.Join(", ", B));
            WriteLine("C [{0}]", string.Join(", ", C));

            MaxDoubleSliceSum sol = new MaxDoubleSliceSum();
            result = sol.solution(A);
            WriteLine("solution A result : {0}", result);
            result = sol.solution(B);
            WriteLine("solution B result : {0}", result);
            result = sol.solution(C);
            WriteLine("solution C result : {0}", result);

            result = sol.solution1(A);
            WriteLine("solution1 A result : {0}", result);
            result = sol.solution1(B);
            WriteLine("solution1 B result : {0}", result);
            result = sol.solution1(C);
            WriteLine("solution1 C result : {0}", result);

            result = sol.solution2(A);
            WriteLine("solution2 A result : {0}", result);
            result = sol.solution2(B);
            WriteLine("solution2 B result : {0}", result);
            result = sol.solution2(C);
            WriteLine("solution2 C result : {0}", result);



        }

        static void CountFactors()
        {
            int N = 24;

            WriteLine("{0}", N);
            CountFactors sol = new CountFactors();
            var result = sol.solution(N);
            WriteLine("solution result : {0}", result);
        }

        static void MinPerimeterRectangle()
        {
            int N = 36;

            WriteLine("{0}", N);
            MinPerimeterRectangle sol = new MinPerimeterRectangle();
            var result = sol.solution(N);
            WriteLine("solution result : {0}", result);
        }

        static void Peaks()
        {
             int[] A = new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            Peaks sol = new Peaks();
            result = sol.solution(A);
            WriteLine("solution A result : {0}", result);

            sol = new Peaks();
            result = sol.solution1(A);
            WriteLine("solution1 A result : {0}", result);
        }

        static void Flags()
        {
            int[] A = new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 };
            int result;

            WriteLine("[{0}]", string.Join(", ", A));

            Flags sol = new Flags();
            result = sol.solution(A);
            WriteLine("solution A result : {0}", result);

            sol = new Flags();
            result = sol.solution1(A);
            WriteLine("solution A result : {0}", result);
        }


    }
}
