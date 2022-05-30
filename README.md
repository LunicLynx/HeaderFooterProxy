# HeaderFooterProxy

**This is a POC.**

Add Layout via Razor Page Proxy.

## Implementation

Requests to the `HeaderFooter` App are proxied to the `Body` App. The `Body` App doesn't have an own `_Layout.cshtml`. This is added in the `ProxyPage.cs` in the `HeaderFooter` App.

## Use

Start both projects. Click Links.

## Why?

This can be usefull if you want many pages to reuse the same Layout. Corporate layout for example. Also this could solve auth offloading and should be easily scalable.

## Issues

Biggest problem would be configuration of forward routing. Especially in cases where there are dynamic pages.

## TODO

[] Should use Streams instead of in memory strings. 
