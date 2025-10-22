using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace PetaPoco
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建一个Page<T>实例
            var page = new Page<string>
            {
                CurrentPage = 1,
                TotalPages = 10,
                TotalItems = 100,
                ItemsPerPage = 10,
                Items = new List<string> { "item1", "item2", "item3" }
            };

            // 使用Newtonsoft.Json序列化
            string json = JsonConvert.SerializeObject(page);
            Console.WriteLine("Newtonsoft.Json序列化结果:");
            Console.WriteLine(json);

            // 尝试反序列化以验证
            var deserialized = JsonConvert.DeserializeObject<Page<string>>(json);
            Console.WriteLine($"\n反序列化后的值:");
            Console.WriteLine($"CurrentPage: {deserialized.CurrentPage}");
        }
    }
}