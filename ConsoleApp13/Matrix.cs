﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp13
{
    public class Matrix
    {
        int a, b;
        int[,] matrix;
        public Matrix(int a, int b)
        {
            this.a = a;
            this.b = b;
            matrix = new int[a, b];
            Random r = new Random();
            for (int m = 0; m < this.a; m++)
            {
                for (int n = 0; n < this.b; n++)
                {
                    matrix[m, n] = r.Next(4, 9);
                }
            }
        }

        public void Sum(Matrix matrix)
        {
            if (this.matrix.Length <= matrix.matrix.Length)
            {
                for (int a = 0; a < this.a; a++)
                {
                    for (int b = 0; b < this.b; b++)
                    {
                        this.matrix[a, b] += matrix.matrix[a, b];
                    }
                }
            }
            else
            {
                for (int a = 0; a < matrix.a; a++)
                {
                    for (int n = 0; b < matrix.b; b++)
                    {
                        this.matrix[a, b] += matrix.matrix[a, b];
                    }
                }
            }
        }
        public void Multiply(int k)
        {
            for (int a = 0; a < this.a; a++)
            {
                for (int b = 0; b < this.b; b++)
                {
                    matrix[a, b] *= k;
                }
            }
        }
        public void Print()
        {
            for (int a = 0; a < this.a; a++)
            {
                for (int b = 0; b < this.b; b++)
                {
                    Console.Write(this.matrix[a, b] + " ");
                }
                Console.WriteLine();
            }
        }
        public void MatrixMatrix(Matrix matrix)
        {
            int[,] tempMatrix = new int[this.a, matrix.b];
            for (int a = 0; a < this.a; a++)
            {
                for (int b = 0; b < matrix.a; b++)
                {
                    for (int k = 0; k < matrix.b; k++)
                    {
                        tempMatrix[a, b] += this.matrix[a, k] * matrix.matrix[k, b];
                    }
                }
            }
            this.matrix = tempMatrix;
        }
    }
}
