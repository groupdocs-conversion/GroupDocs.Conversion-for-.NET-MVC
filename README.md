# GroupDocs.Conversion for .NET MVC Example
###### version 0.1.0

[![Build status](https://ci.appveyor.com/api/projects/status/dl03chqh21wwkysj/branch/master?svg=true)](https://ci.appveyor.com/project/egorovpavel/groupdocs-conversion-for-net-mvc/branch/master)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/2b18e93ff07c440a98b70dd84f1b6ebb)](https://www.codacy.com/app/GroupDocs/GroupDocs.Conversion-for-.NET-MVC?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC&amp;utm_campaign=Badge_Grade)
[![GitHub license](https://img.shields.io/github/license/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC.svg)](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC/blob/master/LICENSE)

## System Requirements
- .NET Framework 4.5
- Visual Studio 2015



## All-in-one document manipulation API

**GroupDocs.Conversion for .NET API** is a suite of powerful, flexible and high-performance libraries which allows you to manipulate documents within your desktop solutions and web apps without requiring any other commercial application. GroupDocs.Conversion allows you to perform all kinds of operations (view, edit, annotate, sign, compare, convert, merge, search, parse, redact, etc) with **PDF, DOCX, PPT, XLS**, and over 90 other document formats.

This web application demonstrates the following document manipulation capabilities:

- Document conversion

**Note:** without a license application will run in trial mode, purchase [GroupDocs.Conversion for .NET license](https://purchase.groupdocs.com/order-online-step-1-of-8.aspx) or request [GroupDocs.Conversion for .NET temporary license](https://purchase.groupdocs.com/temporary-license).

## Supported document Formats

| Family                      | Formats                                                                                                                            |
| --------------------------- |:---------------------------------------------------------------------------------------------------------------------------------- |
| Portable Document Format    | `PDF`                                                                                                                              |
| Microsoft Word              | `DOC`, `DOCM` , `DOCX`, `DOT`, `DOTM`, `DOTX`                                                                                      |
| Microsoft Excel             | `XLS`, `XLSB`, `XLSM`, `XLSX`, `XLT`, `XLTM`, `XLTX`                                                                               |
| Microsoft PowerPoint        | `PPT`, `POT`, `POTM`, `POTX`, `PPS`, `PPSM`, `PPSX`, `PPTM`, `PPTX`                                                                |
| Microsoft Visio             | `VSD`, `VDW`, `VDX`, `VSDX`, `VSS`, `VST`, `VSX`, `VTX`                                                                            |
| Microsoft Project           | `MPP`, `MPT`                                                                                                                       |
| Microsoft Outlook           | `EML`, `EMLX`, `MSG`                                                                                                               |
| OpenDocument Formats        | `ODT`, `ODP`, `ODS`, `OTT`                                                                                                         |
| Plain Text File             | `TXT`                                                                                                                              |
| Comma-Separated Values      | `CSV`                                                                                                                              |
| HyperText Markup Language   | `HTML`, `MHT`, `MHTML`, `SVG`                                                                                                      |
| Extensible Markup Language  | `XML`,`XML`, `XPS`                                                                                                                 |
| AutoCAD Drawing File Format | `DGN`, `DWG`, `DXF`                                                                                                                |
| Image files                 | `BMP`, `CAL`, `DCX`, `DIB`, `EMF`, `GIF`, `JP2`, `JPG`, `MIL`, `MIL`, `PCD`, `PCT`, `PCX`, `PNG`, `PSD`, `RAS`, `TGA`,`TIFF`,`WMF` |
| Electronic publication      | `EPUB`                                                                                                                             |
| Windows Icon                | `ICO`                                                                                                                              |
| Medical image files         | `DCM`                                                                                                                              | 


## Demo Video
Coming soon


## Features
#### [View documents](https://github.com/groupdocs-conversion/GroupDocs.Conversion-for-.NET-MVC) with GroupDocs.Conversion
- Convert different document types to each other

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