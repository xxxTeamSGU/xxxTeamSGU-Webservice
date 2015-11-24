<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="Service_GiayDep.Azure" generation="1" functional="0" release="0" Id="5a123ccf-a24a-4eb1-8034-07a69da67cc3" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="Service_GiayDep.AzureGroup" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="Service_GiayDep:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/LB:Service_GiayDep:Endpoint1" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Service_GiayDep:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/MapService_GiayDep:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="Service_GiayDepInstances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/MapService_GiayDepInstances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:Service_GiayDep:Endpoint1">
          <toPorts>
            <inPortMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/Service_GiayDep/Endpoint1" />
          </toPorts>
        </lBChannel>
      </channels>
      <maps>
        <map name="MapService_GiayDep:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/Service_GiayDep/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapService_GiayDepInstances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/Service_GiayDepInstances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="Service_GiayDep" generation="1" functional="0" release="0" software="C:\Users\huy\Desktop\Service_GiayDep\Service_GiayDep.Azure\csx\Debug\roles\Service_GiayDep" entryPoint="base\x64\WaHostBootstrapper.exe" parameters="base\x64\WaIISHost.exe " memIndex="-1" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;Service_GiayDep&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;Service_GiayDep&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/Service_GiayDepInstances" />
            <sCSPolicyUpdateDomainMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/Service_GiayDepUpgradeDomains" />
            <sCSPolicyFaultDomainMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/Service_GiayDepFaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyUpdateDomain name="Service_GiayDepUpgradeDomains" defaultPolicy="[5,5,5]" />
        <sCSPolicyFaultDomain name="Service_GiayDepFaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="Service_GiayDepInstances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="e66b80bc-1717-497f-9c94-a49ea7e0a458" ref="Microsoft.RedDog.Contract\ServiceContract\Service_GiayDep.AzureContract@ServiceDefinition">
      <interfacereferences>
        <interfaceReference Id="cb20a6aa-d676-4345-8a7f-30cc55a48023" ref="Microsoft.RedDog.Contract\Interface\Service_GiayDep:Endpoint1@ServiceDefinition">
          <inPort>
            <inPortMoniker name="/Service_GiayDep.Azure/Service_GiayDep.AzureGroup/Service_GiayDep:Endpoint1" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>