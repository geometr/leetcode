namespace _498_FindDiagonalOrder
{
    public static class FindDiagonalOrder
    {
        public static int[] Solution(int[][] mat)
        {
            int index = 0;
            int indexX = 0;
            int indexY = 0;
            int maxX = mat[0].Length;
            int maxY = mat.Length;
            bool dir = true;
            int[] result = new int[maxX * maxY];
            while (index < result.Length) {
               
                if (indexX < 0 || indexX >= maxX|| indexY < 0 || indexY >= maxY) { 
                    if (indexY == -1 && indexX == maxX)
                    {
                        indexY = 1;
                        indexX = maxX-1;
                    }
                    if (indexX == -1 && indexY == maxY)
                    {
                        indexX = 1;
                        indexY = maxY-1;
                    }
                    if (indexY < 0) indexY = 0;
                    if (indexX < 0) indexX = 0;
                    if (indexX >=maxX)
                    {
                        indexX = maxX-1;
                        indexY += 2;
                    }
                    if (indexY >= maxY)
                    {
                        indexY = maxY - 1 ;
                        indexX += 2;
                    }
                    dir = !dir;
                }
                result[index] = mat[indexY][indexX];
                if (dir)
                {
                    indexX += 1;
                    indexY -= 1;
                }
                else
                {
                    indexX -= 1;
                    indexY += 1;
                }
                index++;
            }
            return result;
        }
    }
}
