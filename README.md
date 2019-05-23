![Convert pdf to doc or doc to pdf](https://raw.githubusercontent.com/groupdocs-conversion/groupdocs-conversion.github.io/master/resources/image/banner.png "GroupDocs.Conversion")
# GroupDocs.Conversion for .NET MVC Example
###### version 0.1.0

[![Build status](https://ci.appveyor.com/api/projects/status/dl03chqh21wwkysj/branch/master?svg=true)](https://ci.appveyor.com/project/egorovpavel/groupdocs-conversion-for-net-mvc/branch/master)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/2b18e93ff07c440a98b70dd84f1b6ebb)](https://www.codacy.com/app/GroupDocs/GroupDocs.Conversion-for-.NET-MVC?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC&amp;utm_campaign=Badge_Grade)
[![GitHub license](https://img.shields.io/github/license/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC.svg)](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC/blob/master/LICENSE)

## System Requirements
- .NET Framework 4.5
- Visual Studio 2015

## Document converter with .NET API

**GroupDocs.Conversion for .NET API** is a library that allows you to **convert word to PDF, PNG, JPG** and to many other document or image formats supported by the library. Using powerful and flexible GroupDocs.Conversion API you will be able to convert multitude document formats with a wide set of different options.

This web application allows you to convert documents between different formats using simple modern UI. While it can be used as a standalone application it also can be integrated as part of your project.

**Note:** without a license application will run in trial mode, purchase [GroupDocs.Conversion for .NET license](https://purchase.groupdocs.com/order-online-step-1-of-8.aspx) or request [GroupDocs.Conversion for .NET temporary license](https://purchase.groupdocs.com/temporary-license).

## Supported document Formats

| Document family        | Supported formats                                                         | Supported conversions                                                                                                                                |
| ------------------------ | ------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------- |
| Microsoft Word           | `Doc`,`Docm`,`Docx`,`Dot`,`Dotm`,`Dotx`,`Rtf`,`Txt`,`Odt`,`Ott`           | `Word to Rtf`,`Word to Txt`,`Word to Html`,`Word to Odt`,`Word to Ott`,`Word to Epub`,`Word to Pdf`,`Word to Image`,`Word to Cells`,`Word to Slides` |
| Microsoft Excel          | `Xls`,`Xls2003`,`Xlsb`,`Xlsm`,`Xlsx`                                      | `Excel to Word`,`Excel to Pdf`,`Excel to Epub`,`Excel to Html`,`Excel to Image`,`Excel to Slides`                                                    |
| Portable Document Format | `Pdf`                                                                     | `Pdf to Word`,`Pdf to Epub`,`Pdf to Html`,`Pdf to Image`,`Pdf to Cells`,`Pdf to Slides`                                                              |
| Microsoft PowerPoint     | `Ppt`,`Pps`,`Pptx`,`Ppsx`,`Odp`                                           | `Slides to Word`,`Slides to Pdf`,`Slides to Epub`,`Slides to Html`,`Slides to Image`,`Slides to Excel`                                               |
| Microsoft Visio          | `Vsd`,`Vsdx`,`Vss`,`Vst`,`Vsx`,`Vtx`,`Vdw`,`Vdx`,`Svg`                    | `Visio to Word`,`Visio to Pdf`,`Visio to Epub`,`Visio to Html`,`Visio to Image`,`Visio to Excel`,`Visio to Slides`                                   |
| Microsoft Project        | `Mpt`,`Mpp`                                                               | `Tasks to Word`,`Tasks to Pdf`,`Tasks to Epub`,`Tasks to Html`,`Tasks to Image`,`Tasks to Excel`,`Tasks to Slides`                                   |
| HTML                     | `Html`                                                                    | `Html to Word`,`Html to Pdf`,`Html to Epub`,`Html to Cells`,`Html to Slides`                                                                         |
| Images                   | `Xps`,`Tiff`,`Tif`,`Jpeg`,`Jpg`,`Png`,`Gif`,`Bmp`,`Ico`,`Dxf`,`Dwg`,`Psd` | `Image to Word`,`Image to Pdf`,`Image to Epub`,`Image to Html`,`Image to Image`,`Image to Cells`,`Image to Slides`                                   | 



## Demo Video
Coming soon


## Features

- Clean, modern and intuitive design
- Easily switchable colour theme (create your own colour theme in 5 minutes)
- Responsive design
- Convert individual documents
- Batch convert multiple files
- Mobile support (open application on any mobile device)
- HTML and image modes
- Drag and Drop support
- Upload documents
- Cross-browser support (Safari, Chrome, Opera, Firefox)
- Cross-platform support (Windows, Linux, MacOS)

## How to run

You can run this sample by one of following methods

#### Build from source

Download [source code](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC/archive/master.zip) from github or clone this repository.

```bash
git clone https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC
```

Open solution in the VisualStudio.
Update common parameters in `web.config` and example related properties in the `configuration.yml` to meet your requirements.

Open http://localhost:8080/ in your favorite browser

#### Docker image
Use [docker image](https://hub.docker.com/u/groupdocs).

```bash
mkdir DocumentSamples
mkdir Licenses
docker run -p 8080:8080 --env application.hostAddress=localhost -v `pwd`/DocumentSamples:/home/groupdocs/app/DocumentSamples -v `pwd`/Licenses:/home/groupdocs/app/Licenses groupdocs/conversion
## Open http://localhost:8080/ in your favorite browser.
```

## License
The MIT License (MIT). 

Please have a look at the LICENSE.md for more details

## GroupDocs Conversion on other platforms & frameworks

- [GroupDocs.Conversion with JAVA Spring ](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Spring)
- [GroupDocs.Conversion with JAVA Dropwizard ](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-Java-Dropwizard)
- [GroupDocs.Conversion with .NET MVC](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC) 



## Resources
- **Website:** [www.groupdocs.com](http://www.groupdocs.com)
- **Product Home:** [GroupDocs.Conversion for .NET](https://products.groupdocs.com/conversion/NET)
- **Product API References:** [GroupDocs.Conversion for .NET API](https://apireference.groupdocs.com)
- **Download:** [Download GroupDocs.Conversion for .NET](http://downloads.groupdocs.com/conversion/NET)
- **Documentation:** [GroupDocs.Conversion for .NET Documentation](https://docs.groupdocs.com/dashboard.action)
- **Free Support Forum:** [GroupDocs.Conversion for .NET Free Support Forum](https://forum.groupdocs.com/c/conversion)
- **Paid Support Helpdesk:** [GroupDocs.Conversion for .NET Paid Support Helpdesk](https://helpdesk.groupdocs.com)
- **Blog:** [GroupDocs.Conversion for .NET Blog](https://blog.groupdocs.com/category/groupdocs-conversion-product-family)