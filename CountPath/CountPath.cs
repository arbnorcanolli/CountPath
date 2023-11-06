namespace CountPathApp
{
    public class CountPath
    {

        public static void ValidPaths(int X, int Y)
        {
            int validPaths = CountValidPaths(X, Y);
            Console.WriteLine("Number of valid paths: " + validPaths);

            if (validPaths > 0)
            {
                List<string> routes = GenerateRoutes(X, Y);
                Console.WriteLine("Routes for each valid path :");
                foreach (string route in routes)
                {
                    Console.WriteLine(route);
                }
            }
        }

        #region Recursive Method For Counting Valid Paths
        public static int CountValidPaths(int X, int Y)
        {
            if (X == 0 && Y == 0)
            {
                return 1;
            }
            else if (X < 0 || Y < 0)
            {
                return 0;
            }

            return CountValidPaths(X - 1, Y) + CountValidPaths(X, Y - 1);
        }

        #endregion

        public static List<string> GenerateRoutes(int X, int Y)
        {
            List<string> routes = new List<string>();
            GenerateRoutesRecursive(X, Y, "", routes);
            return routes;
        }

        #region Recursive Method For Generating Routes of Valid Paths
        public static void GenerateRoutesRecursive(int X, int Y, string currentRoute, List<string> routes)
        {
            if (X == 0 && Y == 0)
            {
                routes.Add(currentRoute);
                return;
            }

            if (X > 0)
            {
                if (currentRoute.Length < 2 || currentRoute.Substring(currentRoute.Length - 2) != "EE")
                {
                    GenerateRoutesRecursive(X - 1, Y, currentRoute + "E", routes);
                }
            }

            if (Y > 0)
            {
                if (currentRoute.Length < 2 || currentRoute.Substring(currentRoute.Length - 2) != "NN")
                {
                    GenerateRoutesRecursive(X, Y - 1, currentRoute + "N", routes);
                }
            }
        }
        #endregion
    }
}
