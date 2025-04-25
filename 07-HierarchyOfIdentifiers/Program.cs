Tree<int> tree = new() { Root = new() { Data = 100 } };
tree.Root.Children = [
    new() { Data = 50, Parent = tree.Root  },
    new() { Data = 1, Parent = tree.Root  },
    new() { Data = 150, Parent = tree.Root  },
];

tree.Root.Children[0].Children = [
    new() { Data = 12, Parent = tree.Root.Children[0] },
];

tree.Root.Children[0].Children[0].Children = [
    new() { Data = 45, Parent = tree.Root.Children[0].Children[0] },
    new() { Data = 21, Parent = tree.Root.Children[0].Children[0] },
];

tree.Root.Children[0].Children[0].Children[1].Children = [
    new() { Data = 6, Parent = tree.Root.Children[0].Children[0].Children[1] },
];

tree.Root.Children[1].Children = [
    new() { Data = 70, Parent = tree.Root.Children[1] },
    new() { Data = 61, Parent = tree.Root.Children[1] },
];

tree.Root.Children[2].Children = [
    new() { Data = 30, Parent = tree.Root.Children[2] },
];

tree.Root.Children[2].Children[0].Children = [
    new() { Data = 96, Parent = tree.Root.Children[2].Children[0] },
    new() { Data = 9, Parent = tree.Root.Children[2].Children[0] },
];

tree.Root.Children[2].Children = [
    new() { Data = 5, Parent = tree.Root.Children[2] },
    new() { Data = 11, Parent = tree.Root.Children[2] },
];

Console.WriteLine("A tree.");