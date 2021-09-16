# PlatformerBase

I'm making this project to learn how to use Unity 

Things to fix: 
- Collison (Right now, collision works like this: IF objects is inside the wall, stop moving it and push it out in the opposite direction but this causes the object to bounce back and forth which is kind of garbage, I think I should make it so, there's a dummy object that moves before the actual player object and if collision is detected with that, the actual player just doesn't move at all or at the very least moves a smaller distance. That way I think I might prevent the dumb bouncing thing and fix the bug where the object might sometimes get partialy burried underground)
- The Plasma Ball (I don't know how to create a template object, so the thing that you shoot... well the original has to always exist so I can't make it so the ball disappears after a while, this might create performance issues later on so I think it's best to fix it)

Things to add:
- Upgrades, I want this to have some Metroid mechanics
- Enemies