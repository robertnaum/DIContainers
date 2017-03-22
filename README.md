# DIContainers
Sample starter projects for various DI containers.
Need to get up and running quickly with Dependency Injection (DI) containers?

# Step by step instructions for Unity-All
1. Install CommonServiceLocator 1.3
2. Install Unity 4.0.1
3. Install Unity.WebForms 1.4.0
4. Add the following to the appropriate section in **web.config** to allow [Dependency] attribute in .aspx files
   &lt;assemblies&gt;
      &lt;add assembly="System.Runtime, Version=4.0.0.0, Culture=neutral,PublicKeyToken=b03f5f7f11d50a3a" /&gt;
   &lt;/assemblies&gt;
