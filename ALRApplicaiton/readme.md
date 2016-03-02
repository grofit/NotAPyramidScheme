# App Level Resolving Demo

So this demo shows the most basic scenario where you are resolving your dependencies for the application within the consuming application.

## Pros

- Components/Dependencies are unaware of the DI framework (or abstractions of DI framework)
- Application dependency configuration can be tailored to its specific needs
- All application DI configuration is in one place
- Changes to DI configuration ONLY EFFECT THIS APP

## Cons

- Application must know about interface for dependency and concrete class for setting up bindings
- Application must be recompiled for changes in DI to be resolved
- Changes to DI configuration ONLY EFFECT THIS APP (This can be a + or a - based upon your perspective)

## Blurb

One thing to keep in mind is that unless you are using convention based configurations you will end up having the
binding logic somewhere, be it in the components or in the application. 

The main reason I advocate this approach over the components based bindings one is because it should be the application 
explicitly defining how it runs not components TELLING the application how to use it, the whole point of interfaces is
to provide a contract of operation without behaviour so if you automatically have your concrete types assuming they are
the correct binding for the interface then if you have a scenario where there are 2 available types used in different
scenarios it will become more painful to resolve them without the application explicitly overriding the default rules.