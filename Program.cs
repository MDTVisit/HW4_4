class MainClass {
  public static void Main () {
    // Accept the number of nodes in the graph
    Console.Write("Enter the number of nodes in the graph: ");
    int n = Convert.ToInt32(Console.ReadLine());

    // Create a dictionary to store the nodes and their labels
    Dictionary<int, char> labels = new Dictionary<int, char>();

    // Accept the edges between nodes
    while (true) {
      Console.Write("Enter the order of the source node (0 <= i < {0}): ", n);
      int i = Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter the order of the destination node (0 <= j < {0}): ", n);
      int j = Convert.ToInt32(Console.ReadLine());

      // Stop accepting input if the user enters a negative integer or a number that is not less than n
      if (i < 0 || j < 0 || i >= n || j >= n || i == j) {
        break;
      }

      // Assign a label to the source node if it doesn't already have one
      if (!labels.ContainsKey(i)) {
        char label = (char)(labels.Count + 97); // Use the ASCII code for lowercase 'a' to assign labels
        labels[i] = label;
      }

      // Assign the same label to the destination node if it doesn't already have one
      if (!labels.ContainsKey(j)) {
        labels[j] = labels[i];
      }
    }

    // Display the minimum number of symbols required to label all the nodes in the graph
    Console.WriteLine("Minimum number of symbols required: {0}", labels.Values.Distinct().Count());
  }
}
