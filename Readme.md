#Dark Blend theme for WPF 

### A WPF theme which will make an application look like Blend.

![Alt text](Screenshot.png)
Before / After
####List of supported controls
- Button
- CheckBox
- ComboBox
- Expander
- GroupBox
- Label
- ListBox
- ListView
- Menu
- RadioButton
- ScrollViewer
- TabControl
- TextBox
- ToggleButton
- TreeView
- DataGrid

####How to use that theme in your application
#####NuGet
1. To install WPF DarkBlend Theme, run the following command in the Package Manager Console:

```
PM> Install-Package WPFThemes.DarkBlend
```

#####Manually
1. Download the project. 
2. Copy Themes folder with Styles.xaml file to your project. 
In order to use that theme you need just to add a reference to Styles.xaml into the App.xaml file.
So, open App.xaml and add following code:

```
<Application
	...
	<Application.Resources>
		<ResourceDictionary>
           	<ResourceDictionary.MergedDictionaries>
				<ResourceDictionary Source="Themes\Styles.xaml” />
			</ResourceDictionary.MergedDictionaries>
		</ResourceDictionary>
	</Application.Resources>
</Application>
```

If you want to apply the theme to the control which is derived from Window (for example MainWindow) you must add to corresponding xaml a style definition like following.

```
<Window ... Style="{StaticResource {x:Type Window}}”>
```
That's it.

###Feedback

I hope you find it useful. Feel free to contact me for any questions you may have.

###You might be also interested in WPF Office Theme
https://github.com/TanyaPristupova/WpfOfficeTheme
