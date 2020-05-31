﻿using System;
using System.Collections.Generic;
using System.IO;
using Backpropagation.Interfaces;

namespace Backpropagation.Handlers
{
	public class FileHandler : IFileHandler
	{
		private readonly string _folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "NeuralNetwork");
		private readonly string _extension = ".ann";

		public FileHandler()
		{
			if (!Directory.Exists(_folder))
				Directory.CreateDirectory(_folder);
		}

		public string[] ReadFile(string fileName)
		{
			var inputFileName = fileName + _extension;
			var filePath = Path.Combine(_folder, inputFileName);
			return File.Exists(filePath) ? File.ReadAllLines(filePath) : null;
		}

		public void SaveFile(string fileName, string[] outputBuffer)
		{
			int i = 1;
			var num = "";
			string filePath;

			while (true)
			{
				var outputName = fileName + num + _extension;
				filePath = Path.Combine(_folder, outputName);
				if (File.Exists(filePath))
				{
					num = i.ToString();
					i++;
					continue;
				}
				break;
			}
			File.WriteAllLines(filePath, outputBuffer);
		}

		public List<string> FileList()
		{
			List<string> retList = new List<string>();
			IEnumerator<string> iter = Directory.EnumerateFiles(_folder).GetEnumerator();
			while (iter.MoveNext())
			{
				retList.Add(Path.GetFileNameWithoutExtension(iter.Current));
			}
			iter.Dispose();
			return retList;
		}
	}
}