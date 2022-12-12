string input = File.ReadAllText("input.txt");
int maxCalories = input.Split("\r\n\r\n")
    .Max(elf =>
        elf.Split("\r\n")
            .Sum(int.Parse)
    );
Console.WriteLine($"Part 1: {maxCalories}");
