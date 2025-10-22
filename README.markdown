<img align="right" alt="PetaPoco Logo" width="128" src="Media/Logo2/PetaPocoLogo2_256.png">

# PetaPoco2025

这是PetaPoco ORM的修改版，专注于现代化和简洁性。

## 项目特点

- 仅支持 .NET 8.0 和 .NET 9.0
- 修改了 Page 类的 JSON 属性名称，使用更符合习惯的命名（如 pageindex, pagecount 等）
- 使用 System.Text.Json 替代 Newtonsoft.Json 进行 JSON 序列化
- 移除了过时的框架支持和不必要的依赖

## 代码仓库

[GitHub: https://github.com/buzhizhe/PetaPoco2025.git](https://github.com/buzhizhe/PetaPoco2025.git)

## 主要修改

1. **JSON 属性命名优化**：Page 类的属性使用 `[JsonPropertyName]` 属性进行重命名
2. **框架支持精简**：仅保留对 .NET 8.0 和 .NET 9.0 的支持
3. **依赖清理**：移除了过时的依赖项

## JSON 序列化示例

```
{"pageindex":1,"pagecount":10,"total":100,"pagesize":10,"rows":[...],"Context":null}
```

## 使用说明

### 基本用法

以下是PetaPoco的基本使用示例：

## PetaPoco is a tiny & fast micro-ORM for .NET

* Like [Dapper], it's fast because it uses dynamic method generation (MSIL) to assign column values to properties
* Like [Massive], it now also supports dynamic Expandos too
* Like [ActiveRecord], it supports a close relationship between object and database table
* Like [SubSonic], it supports generation of poco classes with T4 templates (V5 only)
* Like [Massive], it's available as a single file that you easily add to any project or complied. (V5 only)

## 主要特性

* 轻量级ORM，性能优秀
* 支持同步和异步操作
* 支持简单POCO类和带属性的POCO类
* 流畅的配置API
* 内置插入/删除/更新/保存等辅助方法
* 自动分页功能，包含总记录数和当前页数据
* 简单易用的事务支持
* 强大的SQL参数替换支持
* 高性能的属性赋值机制（使用DynamicMethod生成）
* 直接使用SQL进行查询
* 内置SQL构建器，简化SQL编写
* 支持多种数据库：SQL Server, SQLite, MySQL, MariaDB, Firebird, PostgreSQL等
* 开源协议：MIT License或Apache 2.0

## Super easy use and configuration

Save an entity
```c#
db.Save(article);
db.Save(new Article { Title = "Super easy to use PetaPoco" });
db.Save("Articles", "Id", { Title = "Super easy to use PetaPoco", Id = Guid.New() });
```

Get an entity
```c#
var article = db.Single<Article>(123);
var article = db.Single<Article>("WHERE ArticleKey = @0", "ART-123");
```

Delete an entity
```c#
db.Delete(article);
db.Delete<Article>(123);
db.Delete("Articles", "Id", 123);
db.Delete("Articles", "ArticleKey", "ART-123");
```

Plus much, much [more](https://github.com/CollaboratingPlatypus/PetaPoco/wiki).

## 贡献指南

欢迎对本项目进行贡献！请参考项目中的CONTRIBUTING.md文件获取详细的贡献指南。

## 许可协议

本项目采用MIT License或Apache 2.0开源协议。

## 原始项目

本项目基于[PetaPoco](https://github.com/CollaboratingPlatypus/PetaPoco)进行修改，保留了其核心功能和设计理念。
