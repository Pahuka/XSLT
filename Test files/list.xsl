<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="xml"/>
<xsl:key name="name" match="item" use="@group"/>

<xsl:template match="list">
  <groups>
    <xsl:apply-templates select="item[generate-id(.) = generate-id(key('name',@group))]">
	<xsl:sort select="@group" order="ascending"/>
	</xsl:apply-templates>
  </groups>
</xsl:template>

<xsl:template match="item">
  <group name="{@group}">	
    <xsl:for-each select="key('name',@group)">	
      <item name="{@name}"/>
    </xsl:for-each>
  </group>
</xsl:template>

</xsl:stylesheet>