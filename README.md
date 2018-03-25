# Azure.Storage.Connection.GetCloudStorageAccount

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-connection-getcloudstorageaccount.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/azure-storage-connection-getcloudstorageaccount)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Connection.GetCloudStorageAccount.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.Azure.Storage.Connection.GetCloudStorageAccount)

## Description

Function returns an instance of Microsoft Azure CloudStorageAccount using the given connection string

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
WindowsAzure.Storage | [![NuGet package status](https://img.shields.io/nuget/v/WindowsAzure.Storage.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/WindowsAzure.Storage)

## Dependents

The project below uses this repository as a direct dependency.

Name | Status
---- | ------
[Azure.Storage.Table.GetTableClient](https://github.com/CDorst./Azure.Storage.Table.GetTableClient) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./azure-storage-table-gettableclient.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./azure-storage-table-gettableclient) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..Azure.Storage.Table.GetTableClient.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..Azure.Storage.Table.GetTableClient)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.Azure.Storage.Connection.GetCloudStorageAccount](https://www.nuget.org/packages/CDorst.Azure.Storage.Connection.GetCloudStorageAccount)

## Version

4.0.1

## Metaproject

Azure.Storage.Connection.GetCloudStorageAccount is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

