SELECT VT.IDVrstaTransfera, VT.Opis, PT.IDPodvrstaTransfera, PT.Opis, T.IDKorisnik FROM  
[dbo].[VrstaTransfera] AS VT
RIGHT JOIN [dbo].[PodvrstaTransfera] AS PT
ON VT.IDVrstaTransfera = PT.IDVrstaTransfera
LEFT JOIN [dbo].[Transfer] AS T
ON PT.IDPodvrstaTransfera = T.IDPodvrstaTransfera
WHERE PT.Validna = 1


