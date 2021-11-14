# WPFLocalizationPackage
A great (perhaps the best) WPF localization and theming package from [Tomer Shamam](https://www.linkedin.com/in/tomershamam/?originalSubdomain=il).

The original source code link is no longer available, but I got this code from [Tomer](https://www.linkedin.com/in/tomershamam/?originalSubdomain=il) and publish it with his kind permission. 

The images below are show switching the locale between English and Hebrew (this demo is part of the code)

![image](https://user-images.githubusercontent.com/2833722/141690819-ea7daea9-c3b0-40d7-8fae-a84a714af1e5.png)


![image](https://user-images.githubusercontent.com/2833722/141690827-c98540ba-86f1-4155-8942-42d3a6e4c29c.png)

Many years ago I used this package to localize a WPF application (it had to have English and German versions). It worked great - I could do the localization in record time. 

The package allows switching the locales at run time and also allows localizing any Dependency or Attached properties – not only `strings`. It provides `Translate` markup extension that can be used from within XAML.

In order to localize an application with the help of this package, you need to create XML catalogs for each of the locales you want your application to support. Here is an excerpt from such a catalog that comes with the demo that comes together with the source:

    <Dictionary EnglishName="English" 
                CultureName="English" 
                Culture="en-US">
        <Value Id="0" 
               FlowDirection="LeftToRight" 
               Title="Demo Window" 
               Width="700" 
               Height="340" />
        <Value Id="1" Content="This is a simple text" />
        ...
    <Dictionary>
      
Each `Value` tag has an `Id` attribute used for matching values from the catalogs into XAML or C# code. The rest of the attributes specify WPF object properties and values that those properties should get under the locale.

Here is an example of referring to a catalog value from XAML code:

    <Window ...
            Title="{loc:Translate Title, Uid=0}"
            ...
    >
    
Translate markup extension refers to attribute title under `Value` tag with `Id=0`.

Mapping between the different cultures and catalogs is done with the help of `LanguageDictionary.RegisterDictionary` method, e.g.:

    LanguageDictionary.RegisterDictionary
    (
        CultureInfo.GetCultureInfo("en-US"),
        new XmlLanguageDictionary("Languages/en-US.xml"));

    LanguageDictionary.RegisterDictionary
    (
        CultureInfo.GetCultureInfo("he-IL"),
        new XmlLanguageDictionary("Languages/he-IL.xml"));
    
maps culture “en-US” into en-US.xml catalog file under Languages folder while culture “he-IL” is mapped into he-IL.xml file.

Here is the code to change localization catalog at run time:

    if (LanguageContext.Instance.Culture == CultureInfo.GetCultureInfo("he-IL"))
    {
        LanguageContext.Instance.Culture = CultureInfo.GetCultureInfo("en-US");
    }
    else
    {
        LanguageContext.Instance.Culture = CultureInfo.GetCultureInfo("he-IL");
    }
