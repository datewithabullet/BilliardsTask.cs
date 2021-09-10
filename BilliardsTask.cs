using System;

namespace Billiards
{
    public static class BilliardsTask
    {
        /// <summary>
        /// Расчитывает угол отскока шарика от стены в зависимости от наклона стены и направления движения
        /// </summary>
        /// <param name="directionRadians">Угол направления движения шара</param>
        /// <param name="wallInclinationRadians">Угол</param>
        /// <returns>Угол отскока шарика от стены</returns>
        public static double BounceWall(double directionRadians, double wallInclinationRadians)
        {
            return 2 * wallInclinationRadians - directionRadians;
        }
    }
}