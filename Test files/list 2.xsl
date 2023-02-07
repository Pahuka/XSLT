<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="xml"/>
<xsl:key name="name" match="item" use="@group"/>

<xsl:template match="/">
<root>
  <xsl:apply-templates select="list/item[generate-id(.) = generate-id(key('name',@group))]">
  <xsl:sort select="@group" order="ascending"/>
  </xsl:apply-templates>
</root>
</xsl:template>

<xsl:template match="item">
<tag name="{@group}">
	<xsl:attribute name="count">
		<xsl:value-of select="count(key('name',@group))"/>
	</xsl:attribute>
		<xsl:copy-of select="key('name',@group)"/>
</tag>
</xsl:template>

</xsl:stylesheet>