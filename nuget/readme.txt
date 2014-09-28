Dark Blend theme for WPF

HOW TO INSTALL
In order to use that theme you need just to add a reference to Styles.xaml into the App.xaml file.
So open App.xaml and add Styles.xaml to the application resources:
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

If you want to apply the theme to the control which is derived from Window (for example MainWindow)
you must add to the corresponding tag a style definition like following:
<Window ... Style="{StaticResource {x:Type Window}}”>

If you have questions feel free to contact me.
https://github.com/DanPristupov/WpfThemes
