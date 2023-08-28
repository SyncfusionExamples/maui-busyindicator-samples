# maui-busyindicator-samples
Contains samples for .NET MAUI Busy Indicator
## How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

Refer to this [link](https://help.syncfusion.com/common/essential-studio/licensing/license-key#xamarinforms) for more details.

3. Set any one of the platform specific projects (iOS, Android or UWP) as a start-up project.
4. Clean and build the application.
5. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
# Adding a .NET MAUI Busy Indicator reference
Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI Busy Indicator to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Core and then install it.
**Step 1**: Create a .NET MAUI application project in Visual Studio 2022.

**Step 2**: Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) Nuget to the project from [nuget.org](https://www.nuget.org/).

**Step 3**: In the MauiProgram.cs file, register the Syncfusion.Maui.Core handler as follows.

**C#**
```

using Syncfusion.Maui.Core.Hosting;
namespace AvatarView_ContactList;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        return builder.Build();
    }
}
```

## Customizations in SfBusyIndicator

**XAML**
```
<ContentPage.Content>
        <busyIndicator:SfBusyIndicator x:Name="busyIndicator"
 				        IsRunning="True"
				        Title="Searching..."
                                       DurationFactor="0.4"/>
</ContentPage.Content>
```
![Animation_Speed.gif](https://support.bolddesk.com/kb/agent/attachment/article/13407/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6Ijk3NzciLCJvcmdpZCI6IjMiLCJpc3MiOiJzdXBwb3J0LmJvbGRkZXNrLmNvbSJ9.zOvlOm4_v5TvqYNBqhpBu3-KvKrHvZYtSvS7lRX0V7k)

**XAML**
```
<ContentPage.Content>
    <busyIndicator:SfBusyIndicator x:Name="busyIndicator" 
                                   IsRunning="True"
                                   Title="Searching..."
                                   IndicatorColor="Red"/> 
</ContentPage.Content>

```

![IndicatorColor.gif](https://support.bolddesk.com/kb/agent/attachment/article/13414/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6Ijk3NzkiLCJvcmdpZCI6IjMiLCJpc3MiOiJzdXBwb3J0LmJvbGRkZXNrLmNvbSJ9.jHaQZ1KjHvCCiBdouAiD7ilpyjtKVhEVkCc4xYzSyO4)

**XAML**
```
<ContentPage.Content>
        <busyIndicator:SfBusyIndicator x:Name="busyIndicator" 
                                       IsRunning="True"
				        Title="Searching..."
                                       AnimationType="Cupertino"/>
</ContentPage.Content>

```
![Animation_Type.gif](https://support.bolddesk.com/kb/agent/attachment/article/13412/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6Ijk3NzgiLCJvcmdpZCI6IjMiLCJpc3MiOiJzdXBwb3J0LmJvbGRkZXNrLmNvbSJ9.joagUFmy_kRMnqeuxlPPJIorD9wiaSgDyToxq2csMZU)
