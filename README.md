# DotPdf

## 处理步骤

1. 网页端填充对应PDF表单信息，提交
2. 利用itext解析PDF获取对应的交互式表单字段，设置前端发来的值
3. 生成新的PDF返回

## 代码相关

1. 在Models/Pdf.cs中定义了示例PDF的类
2. 在Pages/pdf.cshtml.cs中进行了了PDF表单的处理