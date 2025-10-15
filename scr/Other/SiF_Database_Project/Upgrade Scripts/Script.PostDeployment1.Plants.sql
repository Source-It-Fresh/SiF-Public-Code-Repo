/*
### ### ### ### ### ### ###
SourceItFresh - Copyright (C) 2020
This SiF file is licensed under v3 of the GNU Affero General Public License.
### ### ###
GNU AGPLv3 lets people do almost anything they want with the project, except distributing closed-source versions.

Permissions of this strongest copyleft license are conditioned on:
Making available the complete source code of works and modifications, 
 which include larger works using a licensed work, under the same license.
Copyright and license notices must be preserved.
Contributors provide an express grant of patent rights.
When a modified version is used to provide a service over a network,
 the complete source code of the modified version must be made available.

This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY,
 without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
### ### ###
See LICENSE.txt for more details or visit <https://www.gnu.org/licenses/>
### ### ### ### ### ### ###
*/

----https://en.wikipedia.org/wiki/Taxonomic_rank
----https://trefle.io/reference
----https://trefle.io/doc/swagger.json

-------   -------   -------   plt   -------   -------   -------
----SET IDENTITY_INSERT [plt].[Domain] ON
----INSERT [plt].[Domain] ([id], [name]) VALUES (1, N'Prokaryote-Bacteria')
----INSERT [plt].[Domain] ([id], [name]) VALUES (2, N'Prokaryote-Archaea')
----INSERT [plt].[Domain] ([id], [name]) VALUES (3, N'Eukarya')
----SET IDENTITY_INSERT [plt].[Domain] OFF
----GO


----https://trefle.io/api/kingdoms?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[Kingdom] ON
----INSERT [plt].[Kingdom] ([id], [name]) VALUES (1, N'Bacteria')
----INSERT [plt].[Kingdom] ([id], [name]) VALUES (2, N'Archaea')
----INSERT [plt].[Kingdom] ([id], [name]) VALUES (3, N'Protozoa')
----INSERT [plt].[Kingdom] ([id], [name]) VALUES (4, N'Chromista')
----INSERT [plt].[Kingdom] ([id], [name]) VALUES (5, N'Plantae')
----INSERT [plt].[Kingdom] ([id], [name]) VALUES (6, N'Fungi')
----INSERT [plt].[Kingdom] ([id], [name]) VALUES (7, N'Animalia')
--INSERT [plt].[Kingdom] ([id], [name]) VALUES (1, N'Plantae')
--SET IDENTITY_INSERT [plt].[Kingdom] OFF
--GO

----https://trefle.io/api/subkingdoms?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[SubKingdom] ON
--INSERT [plt].[SubKingdom] ([id], [name]) VALUES (1, N'Tracheobionta')
--SET IDENTITY_INSERT [plt].[SubKingdom] OFF
--GO

----SET IDENTITY_INSERT [plt].[Kingdom_SubKingdom] ON
--INSERT [plt].[Kingdom_SubKingdom] ([kingdomId], [subKingdomId]) VALUES (1, 1)
----SET IDENTITY_INSERT [plt].[Kingdom_SubKingdom] OFF
--GO



----SET IDENTITY_INSERT [plt].[Phylum] ON
----INSERT [plt].[Phylum] ([id], [name]) VALUES (1, N'Animals')
----INSERT [plt].[Phylum] ([id], [name]) VALUES (2, N'Plants')
----INSERT [plt].[Phylum] ([id], [name]) VALUES (3, N'Fungi')
----INSERT [plt].[Phylum] ([id], [name]) VALUES (4, N'Protista')
----INSERT [plt].[Phylum] ([id], [name]) VALUES (5, N'Bacteria')
----INSERT [plt].[Phylum] ([id], [name]) VALUES (6, N'Archaea')
----SET IDENTITY_INSERT [plt].[Phylum] OFF
----GO

----https://trefle.io/api/divisions?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[Division] ON
--INSERT [plt].[Division] ([id], [name]) VALUES (1, N'Magnoliopsida')  --[Seed plants] flowering plants (258650)
--INSERT [plt].[Division] ([id], [name]) VALUES (2, N'Coniferophyta')  --   [infoGroup] commonName (species)
--INSERT [plt].[Division] ([id], [name]) VALUES (3, N'Pteridophyta')   --[Pteridophytes] ferns, whisk ferns & horsetails (11000)
--INSERT [plt].[Division] ([id], [name]) VALUES (4, N'Cycadophyta')    --[Seed plants] cycads (160)
--INSERT [plt].[Division] ([id], [name]) VALUES (5, N'Gnetophyta')     --[Seed plants] gnetophytes (70)
--INSERT [plt].[Division] ([id], [name]) VALUES (6, N'Equisetophyta')  --   [infoGroup] commonName (species)
--INSERT [plt].[Division] ([id], [name]) VALUES (7, N'Ginkgophyta')    --[Seed plants] ginkgo (1)
--INSERT [plt].[Division] ([id], [name]) VALUES (8, N'Lycopodiophyta') --[Pteridophytes] club mosses (1200)
--INSERT [plt].[Division] ([id], [name]) VALUES (9, N'Psilophyta')     --   [infoGroup] commonName (species)
--SET IDENTITY_INSERT [plt].[Division] OFF
--GO

----SET IDENTITY_INSERT [plt].[SubKingdom_Division] ON
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 1)
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 2)
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 3)
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 4)
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 5)
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 6)
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 7)
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 8)
--INSERT [plt].[SubKingdom_Division] ([subKingdomId], [divisionId]) VALUES (1, 9)
----SET IDENTITY_INSERT [plt].[SubKingdom_Division] OFF
--GO

----https://trefle.io/api/division_classes?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[DivisionClass] ON
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (1,  N'Magnoliopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (2,  N'Pinopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (3,  N'Bryopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (4,  N'Liliopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (5,  N'Uncertain Ascomycota Class')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (6,  N'Ascomycetes')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (7,  N'Hepaticopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (8,  N'Filicopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (9,  N'Andreaeopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (10, N'Anthocerotopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (11, N'Basidiomycetes')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (12, N'Uncertain Basidiomycota Class')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (13, N'Chlorophyceae')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (14, N'Cycadopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (15, N'Ustomycetes')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (16, N'Gnetopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (17, N'Equisetopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (18, N'Ginkgoopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (19, N'Florideophyceae')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (20, N'Lycopodiopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (21, N'Psilopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (22, N'Sphagnopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (23, N'Takakiopsida')
--INSERT [plt].[DivisionClass] ([id], [name]) VALUES (24, N'Ulvophyceae')
--SET IDENTITY_INSERT [plt].[DivisionClass] OFF
--GO

----ToDo: Add Tbl FK_constraints
----ContinueHere
----ToDo: Add rest of link Tbl's

------SET IDENTITY_INSERT [plt].[Division_DivisionClass] ON
----INSERT [plt].[Division_DivisionClass] ([id], [name]) VALUES (1, 3)
----INSERT [plt].[Division_DivisionClass] ([id], [name]) VALUES (2, 2)
----INSERT [plt].[Division_DivisionClass] ([id], [name]) VALUES (3, 1)
------SET IDENTITY_INSERT [plt].[Division_DivisionClass] OFF
----GO



----https://trefle.io/api/division_orders?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[DivisionOrder] ON
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (1,  N'Dipsacales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (2,  N'Malvales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (3,  N'Pinales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (4,  N'Hypnales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (5,  N'Cyperales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (6,  N'Caryophyllales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (7,  N'Uncertain Ascomycota Order')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (8,  N'Fabales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (9,  N'Ostropales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (10, N'Rosales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (11, N'Euphorbiales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (12, N'Asterales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (13, N'Lamiales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (14, N'Scrophulariales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (15, N'Lecanorales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (16, N'Pottiales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (17, N'Sapindales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (18, N'Ranunculales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (19, N'Calycerales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (20, N'Liliales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (21, N'Apiales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (22, N'Myrtales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (23, N'Solanales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (24, N'Arecales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (25, N'Arales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (26, N'Orchidales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (27, N'Jungermanniales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (28, N'Dothideales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (29, N'Caliciales')
--INSERT [plt].[DivisionOrder] ([id], [name]) VALUES (30, N'Polypodiales')
--SET IDENTITY_INSERT [plt].[DivisionOrder] OFF
--GO



----https://trefle.io/api/families?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[Family] ON
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (1,  N'Caprifoliaceae',              N'Honeysuckle family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (2,  N'Malvaceae',                   N'Mallow family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (3,  N'Pinaceae',                    N'Pine family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (4,  N'Thuidiaceae',                 NULL)
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (5,  N'Cyperaceae',                  N'Sedge family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (6,  N'Sterculiaceae',               NULL)
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (7,  N'Nyctaginaceae',               N'Four o''lock family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (8,  N'Uncertain Ascomycota Family', NULL)
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (9,  N'Fabaceae',                    N'Pea family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (10, N'Stictidaceae',                NULL)
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (11, N'Rosaceae',                    N'Rose family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (12, N'Euphorbiaceae',               N'Spurge family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (13, N'Asteraceae',                  N'Aster family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (14, N'Cactaceae',                   N'Trefle family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (15, N'Lamiaceae',                   N'Mint family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (16, N'Acanthaceae',                 N'Acanthus family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (17, N'Acarosporaceae',              NULL)
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (18, N'Pottiaceae',                  NULL)
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (19, N'Aceraceae',                   N'Maple family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (20, N'Berberidaceae',               N'"Barberry family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (21, N'Poaceae',                     N'Grass family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (22, N'Amaranthaceae',               N'Amaranth family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (23, N'Caryophyllaceae',             N'Pink family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (24, N'Calyceraceae',                N'Calycera family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (25, N'Iridaceae',                   N'Iris family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (26, N'Apiaceae',                    N'Carrot family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (27, N'Melastomataceae',             N'Melastome family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (28, N'Solanaceae',                  N'Potato family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (29, N'Arecaceae',                   N'Palm family')
--INSERT [plt].[Family] ([id], [name], [commonName]) VALUES (30, N'Ranunculaceae',               N'Buttercup family')
--SET IDENTITY_INSERT [plt].[Family] OFF
--GO



----https://trefle.io/api/genuses?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[Genus] ON
--INSERT [plt].[Genus] ([id], [name]) VALUES (1,  N'Abelia')
--INSERT [plt].[Genus] ([id], [name]) VALUES (2,  N'Abelmoschus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (3,  N'Hibiscus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (4,  N'Abies')
--INSERT [plt].[Genus] ([id], [name]) VALUES (5,  N'Pinus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (6,  N'Abietinella')
--INSERT [plt].[Genus] ([id], [name]) VALUES (7,  N'Hypnum')
--INSERT [plt].[Genus] ([id], [name]) VALUES (8,  N'Thuidium')
--INSERT [plt].[Genus] ([id], [name]) VALUES (9,  N'Abildgaardia')
--INSERT [plt].[Genus] ([id], [name]) VALUES (10, N'Cyperus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (11, N'Fimbristylis')
--INSERT [plt].[Genus] ([id], [name]) VALUES (12, N'Abroma')
--INSERT [plt].[Genus] ([id], [name]) VALUES (13, N'Ambroma')
--INSERT [plt].[Genus] ([id], [name]) VALUES (14, N'Abronia')
--INSERT [plt].[Genus] ([id], [name]) VALUES (15, N'Abrothallus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (16, N'Buelliella')
--INSERT [plt].[Genus] ([id], [name]) VALUES (17, N'Abrus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (18, N'Absconditella')
--INSERT [plt].[Genus] ([id], [name]) VALUES (19, N'Abutilon')
--INSERT [plt].[Genus] ([id], [name]) VALUES (20, N'Abortopetalum')
--INSERT [plt].[Genus] ([id], [name]) VALUES (21, N'Acacia')
--INSERT [plt].[Genus] ([id], [name]) VALUES (22, N'Mimosa')
--INSERT [plt].[Genus] ([id], [name]) VALUES (23, N'Acaciella')
--INSERT [plt].[Genus] ([id], [name]) VALUES (24, N'Acaena')
--INSERT [plt].[Genus] ([id], [name]) VALUES (25, N'Acalypha')
--INSERT [plt].[Genus] ([id], [name]) VALUES (26, N'Acamptopappus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (27, N'Aplopappus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (28, N'Acanthocereus')
--INSERT [plt].[Genus] ([id], [name]) VALUES (29, N'Trefle')
--INSERT [plt].[Genus] ([id], [name]) VALUES (30, N'Cereus')
--SET IDENTITY_INSERT [plt].[Genus] OFF
--GO



----https://trefle.io/api/plants?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[Plant] ON
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196589, N'Dianthera ciliata',                      NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196798, N'Adhatoda tristis',                       NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196684, N'Justicia nasuta',                        NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (132811, N'Pothos aurea',                           NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (201041, N'Pleiospilos latipetalus',                NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196753, N'Rhytiglossa secunda var. intermedia',    NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (133929, N'Eriochloa ramosa var. pseudoacrotricha', NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196764, N'Justicia panarensis',                    NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196783, N'Staurogyne leptocaulis',                 NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196789, N'Justicia schomburgkiana',                NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196795, N'Acanthus arboreus',                      NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (134794, N'Eriophorum komarovii',                   NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196826, N'Barleria eranthemoides',                 NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196889, N'Lepidagathis appendiculata',             NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196899, N'Aphelandra madrensis',                   NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196843, N'Ruellia exostemma',                      NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196865, N'Megalochlamys tanzaniensis',             NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (199017, N'Aloinopsis loganii',                     NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196991, N'Isoglossa ufipensis',                    NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (197001, N'Ptyssiglottis nigrescens',               NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (135854, N'Eulalia',                                NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (136273, N'Euphrasia arctica ssp. borealis',        NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (196933, N'Pseuderanthemum hildebrandtii',          NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (137114, N'Ficus perforata',                        NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (136209, N'Euphorbia darlingtonii',                 NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (197013, N'Anisotes dumosus',                       NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (197022, N'Dipteracanthus tuberosu',                NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (197036, N'Hygrophila spiciformis',                 NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (197052, N'Isoglossa laxa',                         NULL)
--INSERT [plt].[Plant] ([id], [scientificName], [commonEnglishName]) VALUES (136739, N'Facelis',                                N'trampweed')
--SET IDENTITY_INSERT [plt].[Plant] OFF
--GO



----Species
----https://trefle.io/api/species?token=amtwVFdiZEE1NDVSSlhlMjJnZXFwZz09
--SET IDENTITY_INSERT [plt].[Species] ON
--INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (131972, 'Elymus fibrosus ssp. fibrosus', NULL,               'Grass family',     0, 0, 131971, 'ssp',     'Unknown',  0)
--INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (196589, 'Dianthera ciliata',             NULL,               NULL,               1, 1, 196589, NULL,      'Synonym',  0)
--INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (196798, 'Adhatoda tristis',              NULL,               NULL,               0, 1, 196798, 'species', 'Accepted', 0)
--INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (196684, 'Justicia nasuta',               NULL,               NULL,               1, 1, 196684, NULL,      'Synonym',  0)
--INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (132235, 'Empetrum eamesii ssp. eamesii', 'purple crowberry', 'Crowberry family', 0, 0, 132229, 'ssp',     'Unknown',  0)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (166120, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
----INSERT [plt].[Species] ([id], [scientificName], [commonName], [familyCommonName], [synonym], [isMainSpecies], [mainSpeciesId], [type], [status], [completeData]) VALUES (000000, 'scientificName', commonName, familyCommonName, synonym, isMainSpecies, mainSpeciesId, 'type', 'status', completeData)
--SET IDENTITY_INSERT [plt].[Species] OFF
--GO

-------   -------   -------   plt   -------   -------   -------