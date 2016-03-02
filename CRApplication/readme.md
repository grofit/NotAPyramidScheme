# Convention Resolving Demo

So this demo shows a more advanced scenario where you setup conventions and adhere to them for automatic binding logic.

## Pros

- Components/Dependencies are unaware of the DI framework (or abstractions of DI framework)
- Application can use implicit conventions AND explicit bindings if needed
- Application DI configuration is generated at runtime so restarting an app will pickup changes
- Changes to DI configuration ONLY EFFECT THIS APP

## Cons

- No explicit configuration can confuse people who are unfamiliar with project and use-cases
- Changes to DI configuration ONLY EFFECT THIS APP (This can be a + or a - based upon your perspective)

## Blurb

This is one technique which separates most basic DI frameworks from the more complex ones, as in most scenarios
the main issue with DI configuration is that its too verbose and most of it is boilerplate. 

So this approach solves a lot of those issues and also provides some level of flexibility for automatic 
binding logic, as historically XML configuration was favoured as you could change it and restart the app
and the new config would be resolved. This same benefit is produced when you use conventional based approaches
as if you adhere to the conventions your bindings will be analysed at runtime and this will re-build the 
binding tree.

Ultimately this approach offers maximum flexibility to swap and change configurations as well as reducing
a huge amount of boilerplate and simple configuration logic. You are also still free to add explicit binding 
logic or custom AOP bindings if required, but this flexibility and reduced maintenance cost comes with some
level of complexity and may cause stumbles for people not used to this approach.