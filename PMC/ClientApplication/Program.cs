using System;
using System.Linq;
using DataModel.Factories.Default;
using DataModel.Models;
using DataModel.Models.Matrices;
using System.IO;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("data.txt", "Example 1:\n");
            File.WriteAllText("data.txt", ExampleOne().ToString());
            File.WriteAllText("data.txt", "Example 2:\n");
            File.WriteAllText("data.txt", ExampleOne().ToString());

            Console.Write("Open " + @Environment.CurrentDirectory + @"\data.txt to see results");
            Console.ReadKey();
        }

        static ContainersCollection<decimal> ExampleOne()
        {
            var factory = new DefaultContainerFactory<decimal>();
            const int positionCount = 100;
            Type[] types = new Type[]
            {
                typeof(MatrixXY<>),
                typeof(MatrixX<>)
            };
            int[][] points = new int[types.Count()][];
            Container<decimal>[] containers = new Container<decimal>[3];

            points[0] =
                    new int[] { 50, 200 }.Concat(
                    Enumerable.Repeat(0, positionCount - 2)
                    ).ToArray();
            points[1] =
                    new int[] { 4, 7 }.Concat(
                    Enumerable.Repeat(0, positionCount - 2)
                    ).ToArray();


            for (int i = 0; i < containers.Length; ++i)
            {
                containers[i] = factory.Create(types, positionCount, points);
            }

            return new ContainersCollection<decimal>(containers);
        }

        static ContainersCollection<double> ExampleTwo()
        {
            var factory = new DefaultContainerFactory<double>();
            const int positionCount = 1;
            Type[] types = new Type[]
            {
                typeof(MatrixXY<>),
                typeof(MatrixXY<>),
                typeof(MatrixXY<>),
                typeof(MatrixXY<>),
                typeof(MatrixXY<>),
                typeof(MatrixX<>),
                typeof(MatrixX<>),
                typeof(MatrixX<>),
                typeof(MatrixX<>),
                typeof(MatrixX<>)
            };
            int[][] points = new int[types.Count()][];
            Container<double>[] containers = new Container<double>[10];

            for (int i = 0; i < points.Length; ++i)
            {
                points[i] = new int[] { 1 };
            }

            for (int i = 0; i < containers.Length; ++i)
            {
                containers[i] = factory.Create(types, positionCount, points);
            }

            return new ContainersCollection<double>(containers);
        }
    }
}
