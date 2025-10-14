# SiF-Public-Code-Repo
Source-It-Fresh Public-Code-Repo.

Typically lags 1 major release version behind the Internal-Private Main-Repo.
Please contact us via 'https://sourceitfresh.org/en/people-needed' or email:'paper@sourceitfresh.com'.

## Overview of Dev Vision :
Everything is designed from the ground up with the end-users’ daily tasks in mind. We’re ultimately in the business of helping people reach their goals with minimal effort, planning to reuse the wheel wherever possible. By utilising community-built, distributable code objects we can, as close as possible, give a free-for-everyone forever experience, with actively maintained peer-reviewed subsystems.
Finally, all non-vulnerable code repos and infrastructure designs will be open-sourced. Excluding Security mechanisms and integrations.

## Beliefs and Assumptions : 
End-user owns a digital device that has internet connectivity for the initial installation and data synchronisation.
End-users should be able to use any subsystem completely independently while allowing full traceable coupling between code objects.
Security first (Industry standard mechanisms / don’t store any login info other than id’s)
Flat hierarchies, every user/org is equal, no biases (Exception - Location-based filtering)
No rating system as it can be abused by bad actors.
The basic system should be fully unlocked and free to use with sufficient "reusable" slots provided from day one. The only limitation is on big-scale data.

We’re open-sourcing the bulk of the application/knowledge base for anyone to comment on and improve on.
Sidenote: Even though we use an assortment of tenancy tools, from a hosting perspective the application is not fully multi-tenant capable in its current state.

To cater to most, we’ve included a dynamic customisable interface to accommodate any existing setup / current modules. For prioritising, and possibly rewarding permaculture and biomimicry systems over monoculture/tilling practices, we’ve catered for but not yet implemented, incentivising proactive users. Comments welcomed!

##	Implementation Evolution History : 
Over the last several years we’ve run multiple Research and Development projects whilst simultaneously building and iterating the bulk of the: -

Modules; Structures; Architecture; Scaffolding; Libraries; Database and more for the proposed design.

We initially investigated ‘NopCommerce’ and ‘OpenCart’ like platforms for the SIF code base in addition to self-hosted Java HTML5 CSS setups with Google’s Firebase as a bare-bones concept and serverless multitenant AWS, Azure, and DELL hosting modules.

Styling was prototyped with in-page reactive bootstrap, script injection SCSS, Radzen, Mudblazor, and more.

In the Blazor realm, we experimented with ASPNET, MVC, MVVM, Server/Client/Hybrid/MAUI, and others.

Regarding Code Repro’s we looked at local GIT, SVN, VS-Online, Azure:GIT / DevOps:TFS ++.

After multiple discussions and mini POC's we adopted an MS-dominant ecosystem due to toolset familiarity, widely adopted industry standards, and the array of technologies Blazor can leverage off of. With almost seamless integration between portals tools dashboards and dev tools, we decided on a slower but thorough approach starting with more bleeding-edge tech that should have reached maturity and wider adoption prior to release while remaining agile enough to swap out any subcomponent without influencing other parts of the ecosystem.

The focus is to build true redundancy by having all sections replaceable by other vendors / tech-stacks even if it is different, SiF origination points shouldn’t care.

| 1. 1.	Common - Portable:                | 2.	Legacy - Preparations:                            |
|-----------------------------------------|-------------------------------------------------------|
| v8.11.x – TestingSuite                  | v3.0.x - Console (Test)                               |
| v8.11.x - Shared ClassLibraries         | v3.0.x - Standard ClassLibraries (Core)               |
| v8.11.x - ASPNetCore Helper WebAPIs     | v3.0.x - SQL Database Project (HandCarfted-EF-DB[3NF])|
| v8.11.x - Modules_Interfaces_Definitions| v3.0.x - WinForms App (Draft)                         |

| 3.	Classic - POC:                                     | 4.	Blazor - Prototype:                           |
|--------------------------------------------------------|--------------------------------------------------|
| v5.7.x - MSTest (Tests)                                | v7.10.x - NUnit (Tests)                          |
| v5.7.x - RPV ClassLibraries (Razor Pages & Views)      | v7.10.x - Razor ClassLibraries (RCL)             |
| v5.7.x - ASPNetCore MVC WebApp (Model-View-Controller) | v7.10.x - Static Server-side Rendering App (SSR) |
| v5.7.x - ASPNetCore Razor WebApp (Razor Pages)         | v7.10.x - Progressive WebApplication (PWA)       |

| 5.	MAUI - Pilot:                                | 6.	CloudNative - Preview:             |
|--------------------------------------------------|---------------------------------------|
| v8.11.x - XUnit (Tests)                          | ~~v9.0.x - GenerativeAI (CI/CD_Testing)~~ |
| v8.11.x - MAUI ClassLibraries (MCL)              | ~~v9.0.x - Aspire (Orchestration)~~       |
| v8.11.x - MAUI Blazor Hybrid (App)               | ~~v9.0.x - ASPNetCore gRPC (Services)~~   |
| v8.11.x - MAUI Native App (Model-View-ViewModel) | ~~v9.0.x - ASPNetCore AOT (WebAPIs)~~     |

## Re-imagined Architecture Design : 
Picture it: 
> “
> In the heart of our digital forest, a robust and secure application emerges with harmonious ecosystems - the blending of technology and tranquillity, a symphony orchestrated to precision with Aspire.  Imagine a lightened, circular clearing where security stands as ancient oak guardians, their roots anchored deep. Our application, like a babbling brook, weaves through the landscape.  Identity integration allows users to seamlessly flow throw the undergrowth and there, beneath the canopy, lies Dependency Injection - the mycelium network connecting components, nourishing them with shared resources.
>
> Component Modules - like wildflowers dotting the forest floor. Each module - a delicate bloom, serves a specific purpose.
>
> Like the changing of seasons - We adapt from web browsers to a large array of mobile devices with a harmonious transition experience.
>
> The Blazor-MAUI Hybrid bridges a vast data stream, shaping surrounding elevations.
>
> Resilience, embodied by the steadfast rock formations, is the landscapes guiding principle. As the rainclouds throughput fluctuates from gentle falls, to bursts during storms. Polly shapes the winds that drives the rainclouds - ensuring our app withstands nature’s whims. Whilst migratory bird species, Localization and Globalization, carries the content across borders on consistent UTC currents.
>
> The UI, a tranquil pond, reflects Razor Components rippling, as pebbles of functionality get dropped, from form components to virtualised tables and more.
>
> Their design, inspired by Material Foundation, echoes the forest’s elegant lines and harmonious colors. With navigation panels, pages, and widgets - grouped like reflected constellations.
>
> Beneath moss-covered logs, we find interface structures and digital contracts - the forest’s hidden pathways. Interlinking the winding trails - guiding communication between modules. Classes, like woodland creatures, encapsulate behavior and data. Web services are the forest paths connecting us to distant realms.
>
> Docker’s sturdy acorn containers, ready to instantly sprout, contain the DNA of our creations, each holds an isolated yet interconnected piece of our forest - database, API, UI. The wise old owl, Kubernetes orchestrates the containers, ensuring balance and growth.
>
> So, there it stands - a digital grove, where security, modularity, and resilience sway in the breeze. Sketched on parchment as a map for fellow wanderers to explore. Remember: our forest evolves, adapts, and thrives alongside your actions.
> ”

<br>

---

:scroll: **SiF** is **licensed** under [_**Copyleft GNU Affero General Public License v3.0**_](https://www.gnu.org/licenses/agpl-3.0.en.html). <br>
:email: **Email:** Comments, edit suggestions, and input can be communicated to our team through [**_paper@sourceitfresh.org_**](mailto:paper@sourceitfresh.org?subject=SIF%20Paper%20Feedback). <br>
:handshake: **Note:** See _**https://sourceitfresh.org/en/people-needed**_ to join the team. <br>
