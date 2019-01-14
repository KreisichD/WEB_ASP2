<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" MasterPageFile="Site.master" %>

<asp:Content ID="indexHeadContent" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/Table.css" />
</asp:Content>

<asp:Content ID="indexMainContent" ContentPlaceHolderID="MainContent" runat="server">
    <article class="row">
			<h1 class="col8">News</h1>

			<h2 class="col8 text-center"><mark>Power</mark> function</h2>

			<section class="col4">

				<p class="col8">
					Returns the value of the first argument raised to the power of the second argument.
					Almost all the programming languages have function like this in mathematical libraries.
				</p>
			</section>
			<aside class="col4 tableAside">
				<table style="border:1px solid black;">
					<caption>Function in programming languages:</caption>
					<tr>
						<th colspan="4">Languages</th>
					</tr>
					<tr>
						<td><img src="MediaFiles/java.png" width="64" height="64" alt="java logo" /></td>
						<td><img src="MediaFiles/csharp.png" width="64" height="64" alt="c# logo" /></td>
						<td><img id="goJS" src="MediaFiles/js.png" width="64" height="64" alt="js logo" /></td>
						<td><img src="MediaFiles/python.png" width="64" height="64" alt="python logo" /></td>
					</tr>
					<tr>
						<td>Math.pow(double a, double b)</td>
						<td>Math.Pow(double a, double b)</td>
						<td>Math.pow(base, exponent)</td>
						<td>pow(x, y)</td>
					</tr>
				</table>
			</aside>

			<details>
				<summary class="col8">Documentation sites:</summary>
				<p class="col8"><a href="https://docs.oracle.com/javase/7/docs/api/java/lang/Math.html#pow(double,%20double)">Java Docs</a></p>
				<p class="col8"><a href="https://docs.microsoft.com/en-us/dotnet/api/system.math.pow?view=netframework-4.7.2">C# Docs</a></p>
				<p class="col8"><a href="https://www.w3schools.com/jsref/jsref_pow.asp">Javascript Docs</a></p>
				<p class="col8"><a href="https://docs.python.org/3/library/functions.html#pow">Python Docs</a></p>
			</details>
		</article>
</asp:Content>

