<h1>LaTeX Generator </h1>

<b>LaTeX Generator</b> is a dekstop application that can be used to quickly generate LaTeX files. 
I created it using C# with WPF.
Using this app, you can generate documents with:
<ul>
  <li> Any number of sections </li>
  <li> Any number of items per section wrapped in an <b> enumerate </b> environment
  <li> Include both simple packages, like <i>tcolorbox</i> and composite packages, like <i>[utf8]inputenc</i>
  The list of packages to include can be updates in the config files, separating subsequeng packages with a semi-colon.
  <li> By checking <b>generate tcolorbox</b>, an enviroment will be added taking one additonal parameter: the title, resulting in an
  elegant blue box with the title at the top </li>
</ul>

This program also features a <b> command line interface <b> with the following parameters:
<ul>
  <li> -i n </li> generates <i> n </i> <i> \item </i> tags within each section
  <li> -s n</li> generates <i> n </i> sections
  <li> -c </li> generates a pre-defined tcolorbox environment.
</ul>

