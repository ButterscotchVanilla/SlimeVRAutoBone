﻿using System;

namespace SlimeVR.AutoBone.Theory
{
    public static class RandomExtensionMethods
    {
        /// <summary>
        /// Generates a random number between <paramref name="min"/> (inclusive) and <paramref name="max"/> (exlusive)
        /// </summary>
        public static double NextDouble(this Random random, double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }

        /// <summary>
        /// Generates a random number between 0 and 1 inclusively
        /// </summary>
        public static double NextDoubleInclusive(this Random random)
        {
            return (random.Next() + random.Next(2)) * (1.0 / int.MaxValue);
        }

        /// <summary>
        /// Generates a random number between <paramref name="min"/> (inclusive) and <paramref name="max"/> (inclusive)
        /// </summary>
        public static double NextDoubleInclusive(this Random random, double min, double max)
        {
            return random.NextDoubleInclusive() * (max - min) + min;
        }

        /// <summary>
        /// Generates a random rotation vector
        /// </summary>
        public static Vector3 NextVectorRotation(this Random random)
        {
            return new Vector3(random.NextDoubleInclusive(-1, 1), random.NextDoubleInclusive(-1, -0.25), random.NextDoubleInclusive(-1, 1)).Normalize();
        }
    }
}