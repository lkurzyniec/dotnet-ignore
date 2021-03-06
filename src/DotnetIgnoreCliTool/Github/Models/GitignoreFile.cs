﻿namespace DotnetIgnoreCliTool.Github.Models
{
    public class GitignoreFile
    {
        public string Name { get; }
        public string Content { get; }
        public static GitignoreFile Empty { get; } = new GitignoreFile(string.Empty, string.Empty);

        public GitignoreFile(string name, string content)
        {
            Name = name;
            Content = content;
        }
    }
}